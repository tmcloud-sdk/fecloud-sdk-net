using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TmCloud.SDK.Core;

namespace TmCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GenRandomRequestBody 
    {

        [JsonProperty("random_data_length", NullValueHandling = NullValueHandling.Ignore)]
        public string RandomDataLength { get; set; }

        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenRandomRequestBody {\n");
            sb.Append("  randomDataLength: ").Append(RandomDataLength).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GenRandomRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GenRandomRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RandomDataLength == input.RandomDataLength ||
                    (this.RandomDataLength != null &&
                    this.RandomDataLength.Equals(input.RandomDataLength))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RandomDataLength != null)
                    hashCode = hashCode * 59 + this.RandomDataLength.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
