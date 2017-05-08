using Sitecore.Diagnostics;
using Sitecore.Pipelines;
using Sitecore.Xdb.Configuration;
using System;

namespace Sitecore.Analytics.Pipelines.CreateVisits
{
  public class ParseGoogleAdWordsParametersPipeline
  {
    public static void Run(ParseGoogleAdWordsParametersArgs parseGoogleAdWordsParametersArgs)
    {
      Assert.ArgumentNotNull(parseGoogleAdWordsParametersArgs, "parseGoogleAdWordsParametersArgs");

      //Check if Tracking is enabled
      if (!XdbSettings.Tracking.Enabled)
      {
        return;
      }

      //Run the GoogleAdWordsParameter pipeline passing the args
      CorePipeline.Run("parseGoogleAdWordsParameters", (PipelineArgs)parseGoogleAdWordsParametersArgs);
    }
  }
}