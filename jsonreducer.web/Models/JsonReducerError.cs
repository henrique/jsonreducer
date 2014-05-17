using System;
using System.Web.Http.ModelBinding;

namespace jsonreducer.web.Models
{
    public class JsonReducerError
    {
        private readonly Exception _exception;
        private readonly ModelStateDictionary _modelState;

        public JsonReducerError()
        {
            Error = string.Format("Could not decode request: JSON parsing failed");
        }

        public JsonReducerError(ModelStateDictionary modelState) : this()
        {
            _modelState = modelState;
            // todo: update error with model state errors, enabled by config
        }

        public JsonReducerError(Exception exception) : this()
        {
            _exception = exception;
            // todo: update error with exection stack trace, enabled by config
        }

        public string Error { get; private set; }
    }
}