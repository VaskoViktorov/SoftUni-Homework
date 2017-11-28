namespace CarDealer.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using Models.Parts;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class PartsController : Controller
    {
        private const int PageSize = 25;
        private const string ModelType = "part";

        private readonly ISupplierService suppliers;
        private readonly IPartService parts;
        private readonly ILogService logs;

        public PartsController(IPartService parts, ISupplierService suppliers, ILogService logs)
        {
            this.parts = parts;
            this.suppliers = suppliers;
            this.logs = logs;
        }

        public IActionResult Create()
            => this.View(new PartFormModel
            {
                AllSuppliers = this.GetSupplierListItems()
            });

        [HttpPost]
        public IActionResult Create(PartFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.AllSuppliers = this.GetSupplierListItems();
                return this.View(model);
            }

            this.parts
                .Create(model.Name, model.Price, model.Quantity, model.SupplierId);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.All));
        }

        public IActionResult Delete(int id)
            => this.View(id);

        public IActionResult Destroy(int id)
        {
            this.parts.Delete(id);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.All));

        }

        public IActionResult Edit(int id)
        {
            var part = this.parts.ById(id);

            if (part == null)
            {
                return this.NotFound();
            }

            return this.View(new PartFormModel
            {
                Name = part.Name,
                Price = part.Price,
                Quantity = part.Quantity,
                IsEdit = true
            });
        }

        [HttpPost]
        public IActionResult Edit(int id, PartFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.IsEdit = true;
                return this.View(model);
            }

            this.parts.Edit(id, model.Price, model.Quantity);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.All));
        }

        public IActionResult All(int page = 1)
            => this.View(new PartPageListingModel
            {
                Parts = this.parts.AllListings(page, PageSize),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(this.parts.Total() / (double)PageSize),
            });

        private IEnumerable<SelectListItem> GetSupplierListItems()
            => this.suppliers
               .All()
               .Select(s => new SelectListItem
               {
                   Text = s.Name,
                   Value = s.Id.ToString()
               });

    }
}
