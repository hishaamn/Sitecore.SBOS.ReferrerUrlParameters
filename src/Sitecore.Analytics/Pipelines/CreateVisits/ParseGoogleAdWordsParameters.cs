using Sitecore.Diagnostics;

namespace Sitecore.Analytics.Pipelines.CreateVisits
{
  public class ParseGoogleAdWordsParameters : CreateVisitProcessor
  {
    public override void Process(CreateVisitArgs args)
    {
      Log.Debug("Entry ParseGoogleAdWordsParameters->Process");

      //Guard clauses
      Assert.ArgumentNotNull(args, "args");
      Assert.ArgumentNotNull(args.Request, "args.Request");
      Assert.ArgumentNotNull(args.Interaction, "args.Interaction");
      Log.Debug("args" + args.ToString());

      //Get the current URL
      var url = args.Request.Url;
      Log.Debug("Uri = " + url.ToString());

      //Get current Interaction
      var currentInteraction = args.Interaction;
      Log.Debug("currentInteraction = " + currentInteraction.ToString());

      ParseGoogleAdWordsParametersPipeline.Run(new ParseGoogleAdWordsParametersArgs()
      {
        Url = url,
        Interaction = currentInteraction
      });

      Log.Debug("Exit ParseGoogleAdWordsParameters->Process");
    }
  }
}