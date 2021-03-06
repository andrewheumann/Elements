//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.4.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Geometry
{
    #pragma warning disable // Disable all warnings

    /// <summary>A plane.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Plane 
    {
        [Newtonsoft.Json.JsonConstructor]
        public Plane(Vector3 @origin, Vector3 @normal)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Plane>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @origin, @normal});
            }
        
            this.Origin = @origin;
            this.Normal = @normal;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The origin of the plane.</summary>
        [Newtonsoft.Json.JsonProperty("Origin", Required = Newtonsoft.Json.Required.AllowNull)]
        public Vector3 Origin { get; set; }
    
        /// <summary>The normal of the plane.</summary>
        [Newtonsoft.Json.JsonProperty("Normal", Required = Newtonsoft.Json.Required.AllowNull)]
        public Vector3 Normal { get; set; }
    
    
    }
}