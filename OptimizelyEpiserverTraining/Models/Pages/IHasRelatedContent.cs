using EPiServer.Core;

namespace OptimizelyEpiserverTraining.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
