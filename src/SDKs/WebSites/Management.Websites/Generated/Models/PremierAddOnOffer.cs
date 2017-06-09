// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Premier add-on offer.
    /// </summary>
    [JsonTransformation]
    public partial class PremierAddOnOffer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PremierAddOnOffer class.
        /// </summary>
        public PremierAddOnOffer() { }

        /// <summary>
        /// Initializes a new instance of the PremierAddOnOffer class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">SKU.</param>
        /// <param name="product">Product.</param>
        /// <param name="vendor">Vendor.</param>
        /// <param name="premierAddOnOfferName">Name.</param>
        /// <param name="promoCodeRequired">&lt;code&gt;true&lt;/code&gt; if
        /// promotion code is required; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="quota">Quota.</param>
        /// <param name="webHostingPlanRestrictions">App Service plans this
        /// offer is restricted to. Possible values include: 'None', 'Free',
        /// 'Shared', 'Basic', 'Standard', 'Premium'</param>
        /// <param name="privacyPolicyUrl">Privacy policy URL.</param>
        /// <param name="legalTermsUrl">Legal terms URL.</param>
        /// <param name="marketplacePublisher">Marketplace publisher.</param>
        /// <param name="marketplaceOffer">Marketplace offer.</param>
        public PremierAddOnOffer(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string sku = default(string), string product = default(string), string vendor = default(string), string premierAddOnOfferName = default(string), bool? promoCodeRequired = default(bool?), int? quota = default(int?), AppServicePlanRestrictions? webHostingPlanRestrictions = default(AppServicePlanRestrictions?), string privacyPolicyUrl = default(string), string legalTermsUrl = default(string), string marketplacePublisher = default(string), string marketplaceOffer = default(string))
            : base(location, id, name, kind, type, tags)
        {
            Sku = sku;
            Product = product;
            Vendor = vendor;
            PremierAddOnOfferName = premierAddOnOfferName;
            PromoCodeRequired = promoCodeRequired;
            Quota = quota;
            WebHostingPlanRestrictions = webHostingPlanRestrictions;
            PrivacyPolicyUrl = privacyPolicyUrl;
            LegalTermsUrl = legalTermsUrl;
            MarketplacePublisher = marketplacePublisher;
            MarketplaceOffer = marketplaceOffer;
        }

        /// <summary>
        /// Gets or sets SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets vendor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string PremierAddOnOfferName { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if
        /// promotion code is required; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.promoCodeRequired")]
        public bool? PromoCodeRequired { get; set; }

        /// <summary>
        /// Gets or sets quota.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quota")]
        public int? Quota { get; set; }

        /// <summary>
        /// Gets or sets app Service plans this offer is restricted to.
        /// Possible values include: 'None', 'Free', 'Shared', 'Basic',
        /// 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "properties.webHostingPlanRestrictions")]
        public AppServicePlanRestrictions? WebHostingPlanRestrictions { get; set; }

        /// <summary>
        /// Gets or sets privacy policy URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privacyPolicyUrl")]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Gets or sets legal terms URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.legalTermsUrl")]
        public string LegalTermsUrl { get; set; }

        /// <summary>
        /// Gets or sets marketplace publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketplacePublisher")]
        public string MarketplacePublisher { get; set; }

        /// <summary>
        /// Gets or sets marketplace offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketplaceOffer")]
        public string MarketplaceOffer { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
