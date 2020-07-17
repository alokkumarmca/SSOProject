﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SSOApp.Controllers.UI;
using SSOApp.Models;
using SSOApp.ViewModels;

namespace SSOApp.Controllers.Admin
{
    public class ClaimsManagementController : Controller
    {
        public async Task<IActionResult> Index()
        {
            await BindTenantDD();
            var getroles = new List<ClaimsViewModel>();
            using (var client = new HttpClient())
            {
                //getallroles
                client.BaseAddress = new Uri("https://localhost:44391/APIClaims/getallclaims");
                var postTask = await client.GetAsync(client.BaseAddress);
                string apiResponse = await postTask.Content.ReadAsStringAsync();
                getroles = JsonConvert.DeserializeObject<List<ClaimsViewModel>>(apiResponse);
            }
            return View(getroles);
        }

        private async Task BindTenantDD()
        {
            using (var client = new HttpClient())
            {
                //getallusers
                client.BaseAddress = new Uri("https://localhost:44391/APITenant/getddtenant");
                var postTask = await client.GetAsync(client.BaseAddress);
                string apiResponse = await postTask.Content.ReadAsStringAsync();
                ViewBag.TenantDD = JsonConvert.DeserializeObject<List<SelectListItem>>(apiResponse);
            }
        }

        public async Task<IActionResult> GetClaimsByTenant(string tcode)
        {
            //TODO: removoe tcode
            tcode = "ABCO";
            var getroles = new List<ClaimsViewModel>();

            using (var client = new HttpClient())
            {
                //getallusers
                if (!string.IsNullOrEmpty(tcode))
                {
                    //Select by code
                    client.BaseAddress = new Uri("https://localhost:44391/APIClaims/getallclaimssbytenant?tcode=" + tcode);
                }
                else
                {
                    //Select All
                    client.BaseAddress = new Uri("https://localhost:44391/APIClaims/getallclaims");
                }
                var postTask = await client.GetAsync(client.BaseAddress);
                string apiResponse = await postTask.Content.ReadAsStringAsync();
                getroles = JsonConvert.DeserializeObject<List<ClaimsViewModel>>(apiResponse);
            }
            return PartialView("_ClaimsGrid", getroles);
        }

        public IActionResult Create()
        {
            var getclaims = new ClaimsViewModel();
            return View(getclaims);
        }

        public async Task<IActionResult> Edit(string cid, string tcode = null)
        {
            var getroles = new ClaimsViewModel();
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    //getrolebyname
                    client.BaseAddress = new Uri("https://localhost:44391/APIClaims/getclaimbyid?id=" + cid + "&tcode=" + tcode);
                    var postTask = await client.GetAsync(client.BaseAddress);
                    string apiResponse = await postTask.Content.ReadAsStringAsync();
                    getroles = JsonConvert.DeserializeObject<ClaimsViewModel>(apiResponse);
                }
            }
            else
                ModelState.AddModelError(string.Empty, AccountOptions.InvalidRoleName);
            return View(getroles);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ClaimsViewModel model)
        {
            model.TenantCode = "ABCO";
            var getroles = new RoleViewModel();
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    //HTTP POST
                    try
                    {

                        client.BaseAddress = new Uri("https://localhost:44391/APIClaims/saveclaim");
                        var json = JsonConvert.SerializeObject(model);
                        var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                        var postTask = await client.PostAsync(client.BaseAddress, stringContent);

                        string apiResponse = await postTask.Content.ReadAsStringAsync();
                        var resultjson = JsonConvert.DeserializeObject<APIReturnedModel>(apiResponse);
                        if (resultjson.status == AccountOptions.API_Response_Saved)
                        {
                            TempData["Success"] = AccountOptions.API_Response_Saved;
                            return RedirectToAction("Index");
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            TempData["Failed"] = AccountOptions.API_Response_Failed;
            return View(model);
        }

        public async Task<IActionResult> Delete(string id)
        {
            using (var client = new HttpClient())
            {
                //HTTP POST
                client.BaseAddress = new Uri("https://localhost:44391/APIClaims/deleteclaim");
                ClaimsViewModel model = new ClaimsViewModel { Name = "NotRequired", ID = id };
                var json = JsonConvert.SerializeObject(model);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var postTask = await client.PostAsync(client.BaseAddress, stringContent);

                string apiResponse = await postTask.Content.ReadAsStringAsync();
                var resultjson = JsonConvert.DeserializeObject<APIReturnedModel>(apiResponse);
                if (resultjson.status == AccountOptions.API_Response_Deleted)
                    TempData["Success"] = AccountOptions.API_Response_Deleted;
                else
                    TempData["Failed"] = AccountOptions.API_Response_Failed;
            }
            return RedirectToAction("Index");
        }
    }
}