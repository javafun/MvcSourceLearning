using System;
using System.Reflection;
using System.Web.Mvc;

namespace MvcSourceCodeLearning.Core.Attributes {
    public class DisplayTextAttribute : Attribute, IMetadataAware {
        private static Type _staticResourceType;
        public string DisplayName { get; set; }
        public Type ResourceType { get; set; }

        public DisplayTextAttribute() {
            ResourceType = _staticResourceType;
        }

        public void OnMetadataCreated(ModelMetadata metadata) {
            this.DisplayName = this.DisplayName ?? (metadata.PropertyName ?? metadata.ModelType.Name);

            if(null == this.ResourceType) {
                metadata.DisplayName = this.DisplayName;
                return;
            }

            PropertyInfo property = this.ResourceType.GetProperty(this.DisplayName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            metadata.DisplayName = property.GetValue(null, null).ToString();
        }

        public static void SetResourceType(Type resourceType) {
            _staticResourceType = resourceType;
        }
    }
}