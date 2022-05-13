using System.Text.Json;
using System.Text.Json.Serialization;

namespace FlintSoft.Tools.Converters;
public class StringToIntConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try
            {
                var val = reader.GetString();
                val = val?.Trim();

                var ret = convert(val ?? "");
                return ret;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        private int convert(string val)
        {

            if (val.Contains("."))
            {
                val = val.Replace(".", ",");
            }

            if (!int.TryParse(val, out var ret))
            {
                if (!double.TryParse(val, out double dblRes))
                {
                    val = val.Replace('.', ',');
                    double.TryParse(val, out dblRes);
                }
                ret = Convert.ToInt32(dblRes);
            }

            return ret;
        }
    }
