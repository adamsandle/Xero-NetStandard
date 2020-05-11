/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.1.2
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// CISOrgSetting
    /// </summary>
    [DataContract]
    public partial class CISOrgSetting :  IEquatable<CISOrgSetting>, IValidatableObject
    {
        
        /// <summary>
        /// true or false - Boolean that describes if the organisation is a CIS Contractor
        /// </summary>
        /// <value>true or false - Boolean that describes if the organisation is a CIS Contractor</value>
        [DataMember(Name="CISContractorEnabled", EmitDefaultValue=false)]
        public bool? CISContractorEnabled { get; set; }

        /// <summary>
        /// true or false - Boolean that describes if the organisation is a CIS SubContractor
        /// </summary>
        /// <value>true or false - Boolean that describes if the organisation is a CIS SubContractor</value>
        [DataMember(Name="CISSubContractorEnabled", EmitDefaultValue=false)]
        public bool? CISSubContractorEnabled { get; set; }

        /// <summary>
        /// CIS Deduction rate for the organisation
        /// </summary>
        /// <value>CIS Deduction rate for the organisation</value>
        [DataMember(Name="Rate", EmitDefaultValue=false)]
        public int? Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CISOrgSetting {\n");
            sb.Append("  CISContractorEnabled: ").Append(CISContractorEnabled).Append("\n");
            sb.Append("  CISSubContractorEnabled: ").Append(CISSubContractorEnabled).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CISOrgSetting);
        }

        /// <summary>
        /// Returns true if CISOrgSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of CISOrgSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CISOrgSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CISContractorEnabled == input.CISContractorEnabled ||
                    this.CISContractorEnabled.Equals(input.CISContractorEnabled)
                ) && 
                (
                    this.CISSubContractorEnabled == input.CISSubContractorEnabled ||
                    this.CISSubContractorEnabled.Equals(input.CISSubContractorEnabled)
                ) && 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.CISContractorEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.CISSubContractorEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.Rate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
