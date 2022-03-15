using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class ProductPagePartialController : PartialContentController<ProductPage>
    {

        public override ActionResult Index(ProductPage currentPage)
        {
            var viewmodel = new DefaultPageViewModel<ProductPage>(currentPage);
            return PartialView(viewmodel);

            //return PartialView(DefaultPageViewModel.Create(currentPage));
            //return PartialView(DefaultPageViewModel<ProductPage>.Create(currentPage));
        }
    }
}