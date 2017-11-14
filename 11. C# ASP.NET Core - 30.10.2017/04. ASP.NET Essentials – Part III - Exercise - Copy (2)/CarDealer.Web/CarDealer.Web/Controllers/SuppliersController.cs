namespace CarDealer.Web.Controllers
{
    using Services;
    using Models.Suppliers;
    using Microsoft.AspNetCore.Mvc;
    using System.Reflection;

    [Route("suppliers")]
    public class SuppliersController : Controller
    {
        private const string SuppliersView = "Suppliers";
        private const string ModelType = "supplier";

        private readonly ISupplierService suppliers;
        private readonly ILogService logs;

        public SuppliersController(ISupplierService supliers, ILogService logs)
        {
            this.suppliers = supliers;
            this.logs = logs;
        }

        [Route(nameof(Local))]
        public IActionResult Local()
        => this.View(SuppliersView, this.GetSupplierModel(false));

        [Route(nameof(Importers))]
        public IActionResult Importers()
        => this.View(SuppliersView, this.GetSupplierModel(true));

        private SupplierListingModel GetSupplierModel(bool importers)
        {
            var type = importers ? "Importer" : "Local";

            var suppliersType = this.suppliers.AllListings(importers);

            return new SupplierListingModel
            {
                Type = type,
                Suppliers = suppliersType
            };
        }

        [Route(nameof(Create))]
        public IActionResult Create()
            => this.View();

        [HttpPost]
        [Route(nameof(Create))]
        public IActionResult Create(SupplierFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            this.suppliers
                .Create(model.Name, model.IsImporter);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            if (model.IsImporter)
            {
                return this.RedirectToAction(nameof(this.Importers));
            }

            return this.RedirectToAction(nameof(this.Local));
        }

        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id)
        {
            var supplier = this.suppliers.ById(id);

            if (supplier == null)
            {
                return this.NotFound();
            }

            return this.View(new SupplierFormModel
            {
                Name = supplier.Name,
                IsImporter = supplier.IsImporter
            });
        }

        [HttpPost]
        [Route(nameof(Edit) + "/{id}")]
        public IActionResult Edit(int id, SupplierFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }
            var customerExists = this.suppliers.Exists(id);

            if (!customerExists)
            {
                return this.NotFound();
            }

            this.suppliers
                .Edit(id, model.Name, model.IsImporter);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            if (model.IsImporter)
            {
                return this.RedirectToAction(nameof(this.Importers));
            }

            return this.RedirectToAction(nameof(this.Local));
        }

        [Route(nameof(Delete) + "/{id}")]
        public IActionResult Delete(int id)
            => this.View(id);

        [Route(nameof(Destroy) + "/{id}")]
        public IActionResult Destroy(int id)
        {
            this.suppliers.Delete(id);

            this.logs.Create(this.User.Identity.Name, MethodBase.GetCurrentMethod().Name, ModelType);

            return this.RedirectToAction(nameof(this.Importers));
        }
    }
}
