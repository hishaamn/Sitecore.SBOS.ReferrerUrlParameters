using Sitecore.Analytics.Pipelines.CreateVisits;
using Sitecore.Collections;
using Sitecore.Diagnostics;
using Sitecore.Xml;
using System;
using System.Collections.Generic;
using System.Web;
using System.Xml;

namespace Sitecore.Analytics.Pipelines.ParseGoogleAdWordsParameters
{
  public class ParseValueTrackParameters
  {
    private readonly SafeDictionary<string, string> dictionary = new SafeDictionary<string, string>();
    public virtual void AddValueTrackParameters(XmlNode node)
    {
      Assert.ArgumentNotNull(node, "node");

      //string valueTrack = XmlUtil.GetAttribute("valuetrack", node);
      string hostName = XmlUtil.GetAttribute("hostname", node);

      try
      {
        dictionary[hostName] = hostName;
      }
      catch (Exception e)
      {
        Log.Error("Could not register parameter name. ParameterName: " + hostName, e, (object)this);
      }
    }

    public void Process(ParseGoogleAdWordsParametersArgs args)
    {
      Assert.ArgumentNotNull(args, "args");

      var referringSite = args.Interaction.ReferringSite;

      foreach (KeyValuePair<string,string> keyValuePair in dictionary)
      {
        //var valueTrack = keyValuePair.Key;
        var targetHostname = keyValuePair.Value;

        //does referring site starts with the target hostname from the parameter xmlnode?
        if (referringSite.StartsWith(targetHostname))
        {
          //parse the referrer's url parameters
          parseParameter(args);
        }
      }
    }
    private bool parseParameter(ParseGoogleAdWordsParametersArgs args)
    {
      Assert.ArgumentNotNull(args, "args");

      //Get the URL query string
      var queryString = args.Url.Query;

      //If empty then exit method
      if (string.IsNullOrEmpty(queryString))
      {
        return false;
      } 

      //does it starts with '?'
      if (queryString.StartsWith("?", StringComparison.InvariantCulture))
      {
        //remove the '?' from the string
        queryString = queryString.Substring(1);
      }

      //split the parameters with the delimiter '&'
      string[] queryParameters = queryString.Split('&');

      //if parameters empty exit method
      if (queryParameters.Length == 0)
      {
        return false;
      }

      //loop thru parameters found
      foreach (string queryParameter in queryParameters)
      {
        //extract the key and value
        string[] keyValuePair = queryParameter.Split('=');

        //if there a pair that we can process?
        if (keyValuePair.Length == 2)
        {
          //get the parameter name
          var parameter = keyValuePair[0];

          //get the decoded value of the pair
          var value = HttpUtility.UrlDecode(keyValuePair[1]);
          if (!string.IsNullOrEmpty(value))
          {
            //get the current interaction
            var currentInteraction = args.Interaction;

            //set keywords value to custom value fields of Interaction
            currentInteraction.CustomValues.Add(parameter, value);
          }
        }
      }

      return true;
    }
  }
}
