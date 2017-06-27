using System;
using Sitecore.Analytics.Tracking;
using Sitecore.Pipelines;
using System.Runtime.Serialization;
using Sitecore.Diagnostics;

namespace Sitecore.Analytics.Pipelines.CreateVisits
{
  [Serializable]
  public class ParseGoogleAdWordsParametersArgs : PipelineArgs
  {
    public CurrentInteraction Interaction
    {
      get;
      set;
    }
    public Uri Url
    {
      get;
      set;
    }
    public ParseGoogleAdWordsParametersArgs()
    {
    }

    protected ParseGoogleAdWordsParametersArgs(SerializationInfo info, StreamingContext context) 
      : base(info, context)
    {
      Assert.ArgumentNotNull(info, "info");
      Assert.ArgumentNotNull(context, "context");
    }
  }
}