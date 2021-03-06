using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Recording 
{

    /// <summary>
    /// FetchTranscriptionOptions
    /// </summary>
    public class FetchTranscriptionOptions : IOptions<TranscriptionResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The recording_sid
        /// </summary>
        public string PathRecordingSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchTranscriptionOptions
        /// </summary>
        ///
        /// <param name="pathRecordingSid"> The recording_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchTranscriptionOptions(string pathRecordingSid, string pathSid)
        {
            PathRecordingSid = pathRecordingSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// DeleteTranscriptionOptions
    /// </summary>
    public class DeleteTranscriptionOptions : IOptions<TranscriptionResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The recording_sid
        /// </summary>
        public string PathRecordingSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteTranscriptionOptions
        /// </summary>
        ///
        /// <param name="pathRecordingSid"> The recording_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteTranscriptionOptions(string pathRecordingSid, string pathSid)
        {
            PathRecordingSid = pathRecordingSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// ReadTranscriptionOptions
    /// </summary>
    public class ReadTranscriptionOptions : ReadOptions<TranscriptionResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The recording_sid
        /// </summary>
        public string PathRecordingSid { get; }

        /// <summary>
        /// Construct a new ReadTranscriptionOptions
        /// </summary>
        ///
        /// <param name="pathRecordingSid"> The recording_sid </param>
        public ReadTranscriptionOptions(string pathRecordingSid)
        {
            PathRecordingSid = pathRecordingSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}