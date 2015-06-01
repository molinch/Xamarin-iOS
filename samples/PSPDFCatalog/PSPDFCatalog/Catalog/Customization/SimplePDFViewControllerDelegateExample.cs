using System;
using PSPDFKit;
using Foundation;

namespace PSPDFCatalog.Catalog.Customization
{
	public class SimplePDFViewControllerDelegateExample: PSPDFViewControllerDelegate
	{
		public override void DidShowPageView(PSPDFViewController pdfController, PSPDFPageView pageView)
		{
			base.DidShowPageView(pdfController, pageView);
		}

		public override bool ShouldShowController(PSPDFViewController pdfController, IPSPDFPresentableViewController controller, IPSPDFHostableViewController hostController, NSDictionary options, bool animated)
		{
			return base.ShouldShowController(pdfController, controller, hostController, options, animated);
		}
	}
}

