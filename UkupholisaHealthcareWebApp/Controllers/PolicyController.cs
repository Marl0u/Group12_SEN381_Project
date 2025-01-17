﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.Models;

namespace UkupholisaHealthcareWebApp.Controllers
{
    public class PolicyController : Controller
    {
        private readonly IPolicyData _policyData;

        public PolicyController(IPolicyData policyData)
        {
            _policyData = policyData;
        }
        // GET: PolicyController
        public ActionResult Index()
        {
            List<Policy> policies = _policyData.GetPolicies();
            return View(policies);
        }

        public ActionResult EditView(int id)
        {
            Policy policy = _policyData.GetPolicyById(id);
            return View(policy);
        }

        public ActionResult Edit(Policy policy)
        {
            _policyData.UpdatePolicy(policy);
            return RedirectToAction("Index");
        }

        public ActionResult CreateView()
        {
            return View();
        }

        // GET: PolicyController/Create
        public ActionResult Create(Policy policy)
        {
            _policyData.InsertPolicy(policy);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _policyData.DeletePolicy(id);
            return RedirectToAction("Index");
        }
    }
}
