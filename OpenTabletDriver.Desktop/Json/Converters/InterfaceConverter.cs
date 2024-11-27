using System;
using Newtonsoft.Json;

namespace OpenTabletDriver.Desktop.Json.Converters
{
    public class InterfaceConverter<TInterface, TClass> : JsonConverter<TInterface> where TInterface : class where TClass : TInterface, new()
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, TInterface? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override TInterface ReadJson(JsonReader reader, Type objectType, TInterface? existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var obj = existingValue ?? new TClass();
            serializer.Populate(reader, obj);
            return obj;
        }
    }
}
