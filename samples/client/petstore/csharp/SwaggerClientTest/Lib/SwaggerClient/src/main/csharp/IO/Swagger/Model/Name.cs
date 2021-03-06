using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Model for testing model name same as property name
    /// </summary>
    [DataContract]
    public partial class Name :  IEquatable<Name>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Name" /> class.
        /// Initializes a new instance of the <see cref="Name" />class.
        /// </summary>
        /// <param name="_Name">_Name (required).</param>

        public Name(int? _Name = null)
        {
            // to ensure "_Name" is required (not null)
            if (_Name == null)
            {
                throw new InvalidDataException("_Name is a required property for Name and cannot be null");
            }
            else
            {
                this._Name = _Name;
            }
            
        }

    
        /// <summary>
        /// Gets or Sets _Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public int? _Name { get; set; }
    
        /// <summary>
        /// Gets or Sets SnakeCase
        /// </summary>
        [DataMember(Name="snake_case", EmitDefaultValue=false)]
        public int? SnakeCase { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Name {\n");
            sb.Append("  _Name: ").Append(_Name).Append("\n");
            sb.Append("  SnakeCase: ").Append(SnakeCase).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Name);
        }

        /// <summary>
        /// Returns true if Name instances are equal
        /// </summary>
        /// <param name="other">Instance of Name to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Name other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Name == other._Name ||
                    this._Name != null &&
                    this._Name.Equals(other._Name)
                ) && 
                (
                    this.SnakeCase == other.SnakeCase ||
                    this.SnakeCase != null &&
                    this.SnakeCase.Equals(other.SnakeCase)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this._Name != null)
                    hash = hash * 59 + this._Name.GetHashCode();
                if (this.SnakeCase != null)
                    hash = hash * 59 + this.SnakeCase.GetHashCode();
                return hash;
            }
        }

    }
}
