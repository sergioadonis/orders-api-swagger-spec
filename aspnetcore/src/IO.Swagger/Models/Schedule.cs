/*
 * Restaurant Orders
 *
 * Simple API to manage restaurant orders
 *
 * OpenAPI spec version: v1
 * Contact: sergio.adonis@outlook.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Schedule : IEquatable<Schedule>
    { 
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days")]
        public string Days { get; set; }

        /// <summary>
        /// Gets or Sets OpenTime
        /// </summary>
        [DataMember(Name="openTime")]
        public string OpenTime { get; set; }

        /// <summary>
        /// Gets or Sets CloseTime
        /// </summary>
        [DataMember(Name="closeTime")]
        public string CloseTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Schedule {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  OpenTime: ").Append(OpenTime).Append("\n");
            sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Schedule)obj);
        }

        /// <summary>
        /// Returns true if Schedule instances are equal
        /// </summary>
        /// <param name="other">Instance of Schedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schedule other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Days == other.Days ||
                    Days != null &&
                    Days.Equals(other.Days)
                ) && 
                (
                    OpenTime == other.OpenTime ||
                    OpenTime != null &&
                    OpenTime.Equals(other.OpenTime)
                ) && 
                (
                    CloseTime == other.CloseTime ||
                    CloseTime != null &&
                    CloseTime.Equals(other.CloseTime)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Days != null)
                    hashCode = hashCode * 59 + Days.GetHashCode();
                    if (OpenTime != null)
                    hashCode = hashCode * 59 + OpenTime.GetHashCode();
                    if (CloseTime != null)
                    hashCode = hashCode * 59 + CloseTime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Schedule left, Schedule right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Schedule left, Schedule right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
