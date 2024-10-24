// <copyright file="ImageOrigin.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ImageOrigin>),
        new Type[] {
            typeof(DockerHubOriginCase),
            typeof(DockerFileOriginCase),
            typeof(DockerRegistryOriginCase),
            typeof(OciRegistryOriginCase),
            typeof(CycleUploadOriginCase),
            typeof(CycleSourceOriginCase),
            typeof(NoneOriginCase)
        },
        new string[] {
            "docker-hub",
            "docker-file",
            "docker-registry",
            "oci-registry",
            "cycle-upload",
            "cycle-source",
            "none"
        },
        "type",
        true
    )]
    public abstract class ImageOrigin
    {
        /// <summary>
        /// This is DockerHubOrigin case.
        /// </summary>
        /// <returns>
        /// The ImageOrigin instance, wrapping the provided DockerHubOrigin value.
        /// </returns>
        public static ImageOrigin FromDockerHubOrigin(DockerHubOrigin dockerHubOrigin)
        {
            return new DockerHubOriginCase().Set(dockerHubOrigin);
        }

        /// <summary>
        /// This is DockerFileOrigin case.
        /// </summary>
        /// <returns>
        /// The ImageOrigin instance, wrapping the provided DockerFileOrigin value.
        /// </returns>
        public static ImageOrigin FromDockerFileOrigin(DockerFileOrigin dockerFileOrigin)
        {
            return new DockerFileOriginCase().Set(dockerFileOrigin);
        }

        /// <summary>
        /// This is DockerRegistryOrigin case.
        /// </summary>
        /// <returns>
        /// The ImageOrigin instance, wrapping the provided DockerRegistryOrigin value.
        /// </returns>
        public static ImageOrigin FromDockerRegistryOrigin(DockerRegistryOrigin dockerRegistryOrigin)
        {
            return new DockerRegistryOriginCase().Set(dockerRegistryOrigin);
        }

        /// <summary>
        /// This is OciRegistryOrigin case.
        /// </summary>
        /// <returns>
        /// The ImageOrigin instance, wrapping the provided OciRegistryOrigin value.
        /// </returns>
        public static ImageOrigin FromOciRegistryOrigin(OciRegistryOrigin ociRegistryOrigin)
        {
            return new OciRegistryOriginCase().Set(ociRegistryOrigin);
        }

        /// <summary>
        /// This is CycleUploadOrigin case.
        /// </summary>
        /// <returns>
        /// The ImageOrigin instance, wrapping the provided CycleUploadOrigin value.
        /// </returns>
        public static ImageOrigin FromCycleUploadOrigin(CycleUploadOrigin cycleUploadOrigin)
        {
            return new CycleUploadOriginCase().Set(cycleUploadOrigin);
        }

        /// <summary>
        /// This is CycleSourceOrigin case.
        /// </summary>
        /// <returns>
        /// The ImageOrigin instance, wrapping the provided CycleSourceOrigin value.
        /// </returns>
        public static ImageOrigin FromCycleSourceOrigin(CycleSourceOrigin cycleSourceOrigin)
        {
            return new CycleSourceOriginCase().Set(cycleSourceOrigin);
        }

        /// <summary>
        /// This is NoneOrigin case.
        /// </summary>
        /// <returns>
        /// The ImageOrigin instance, wrapping the provided NoneOrigin value.
        /// </returns>
        public static ImageOrigin FromNoneOrigin(NoneOrigin noneOrigin)
        {
            return new NoneOriginCase().Set(noneOrigin);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<DockerHubOrigin, T> dockerHubOrigin,
            Func<DockerFileOrigin, T> dockerFileOrigin,
            Func<DockerRegistryOrigin, T> dockerRegistryOrigin,
            Func<OciRegistryOrigin, T> ociRegistryOrigin,
            Func<CycleUploadOrigin, T> cycleUploadOrigin,
            Func<CycleSourceOrigin, T> cycleSourceOrigin,
            Func<NoneOrigin, T> noneOrigin);

        [JsonConverter(typeof(UnionTypeCaseConverter<DockerHubOriginCase, DockerHubOrigin>))]
        private sealed class DockerHubOriginCase : ImageOrigin, ICaseValue<DockerHubOriginCase, DockerHubOrigin>
        {
            public DockerHubOrigin _value;

            public override T Match<T>(
                Func<DockerHubOrigin, T> dockerHubOrigin,
                Func<DockerFileOrigin, T> dockerFileOrigin,
                Func<DockerRegistryOrigin, T> dockerRegistryOrigin,
                Func<OciRegistryOrigin, T> ociRegistryOrigin,
                Func<CycleUploadOrigin, T> cycleUploadOrigin,
                Func<CycleSourceOrigin, T> cycleSourceOrigin,
                Func<NoneOrigin, T> noneOrigin)
            {
                return dockerHubOrigin(_value);
            }

            public DockerHubOriginCase Set(DockerHubOrigin value)
            {
                _value = value;
                return this;
            }

            public DockerHubOrigin Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DockerFileOriginCase, DockerFileOrigin>))]
        private sealed class DockerFileOriginCase : ImageOrigin, ICaseValue<DockerFileOriginCase, DockerFileOrigin>
        {
            public DockerFileOrigin _value;

            public override T Match<T>(
                Func<DockerHubOrigin, T> dockerHubOrigin,
                Func<DockerFileOrigin, T> dockerFileOrigin,
                Func<DockerRegistryOrigin, T> dockerRegistryOrigin,
                Func<OciRegistryOrigin, T> ociRegistryOrigin,
                Func<CycleUploadOrigin, T> cycleUploadOrigin,
                Func<CycleSourceOrigin, T> cycleSourceOrigin,
                Func<NoneOrigin, T> noneOrigin)
            {
                return dockerFileOrigin(_value);
            }

            public DockerFileOriginCase Set(DockerFileOrigin value)
            {
                _value = value;
                return this;
            }

            public DockerFileOrigin Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DockerRegistryOriginCase, DockerRegistryOrigin>))]
        private sealed class DockerRegistryOriginCase : ImageOrigin, ICaseValue<DockerRegistryOriginCase, DockerRegistryOrigin>
        {
            public DockerRegistryOrigin _value;

            public override T Match<T>(
                Func<DockerHubOrigin, T> dockerHubOrigin,
                Func<DockerFileOrigin, T> dockerFileOrigin,
                Func<DockerRegistryOrigin, T> dockerRegistryOrigin,
                Func<OciRegistryOrigin, T> ociRegistryOrigin,
                Func<CycleUploadOrigin, T> cycleUploadOrigin,
                Func<CycleSourceOrigin, T> cycleSourceOrigin,
                Func<NoneOrigin, T> noneOrigin)
            {
                return dockerRegistryOrigin(_value);
            }

            public DockerRegistryOriginCase Set(DockerRegistryOrigin value)
            {
                _value = value;
                return this;
            }

            public DockerRegistryOrigin Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<OciRegistryOriginCase, OciRegistryOrigin>))]
        private sealed class OciRegistryOriginCase : ImageOrigin, ICaseValue<OciRegistryOriginCase, OciRegistryOrigin>
        {
            public OciRegistryOrigin _value;

            public override T Match<T>(
                Func<DockerHubOrigin, T> dockerHubOrigin,
                Func<DockerFileOrigin, T> dockerFileOrigin,
                Func<DockerRegistryOrigin, T> dockerRegistryOrigin,
                Func<OciRegistryOrigin, T> ociRegistryOrigin,
                Func<CycleUploadOrigin, T> cycleUploadOrigin,
                Func<CycleSourceOrigin, T> cycleSourceOrigin,
                Func<NoneOrigin, T> noneOrigin)
            {
                return ociRegistryOrigin(_value);
            }

            public OciRegistryOriginCase Set(OciRegistryOrigin value)
            {
                _value = value;
                return this;
            }

            public OciRegistryOrigin Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CycleUploadOriginCase, CycleUploadOrigin>))]
        private sealed class CycleUploadOriginCase : ImageOrigin, ICaseValue<CycleUploadOriginCase, CycleUploadOrigin>
        {
            public CycleUploadOrigin _value;

            public override T Match<T>(
                Func<DockerHubOrigin, T> dockerHubOrigin,
                Func<DockerFileOrigin, T> dockerFileOrigin,
                Func<DockerRegistryOrigin, T> dockerRegistryOrigin,
                Func<OciRegistryOrigin, T> ociRegistryOrigin,
                Func<CycleUploadOrigin, T> cycleUploadOrigin,
                Func<CycleSourceOrigin, T> cycleSourceOrigin,
                Func<NoneOrigin, T> noneOrigin)
            {
                return cycleUploadOrigin(_value);
            }

            public CycleUploadOriginCase Set(CycleUploadOrigin value)
            {
                _value = value;
                return this;
            }

            public CycleUploadOrigin Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CycleSourceOriginCase, CycleSourceOrigin>))]
        private sealed class CycleSourceOriginCase : ImageOrigin, ICaseValue<CycleSourceOriginCase, CycleSourceOrigin>
        {
            public CycleSourceOrigin _value;

            public override T Match<T>(
                Func<DockerHubOrigin, T> dockerHubOrigin,
                Func<DockerFileOrigin, T> dockerFileOrigin,
                Func<DockerRegistryOrigin, T> dockerRegistryOrigin,
                Func<OciRegistryOrigin, T> ociRegistryOrigin,
                Func<CycleUploadOrigin, T> cycleUploadOrigin,
                Func<CycleSourceOrigin, T> cycleSourceOrigin,
                Func<NoneOrigin, T> noneOrigin)
            {
                return cycleSourceOrigin(_value);
            }

            public CycleSourceOriginCase Set(CycleSourceOrigin value)
            {
                _value = value;
                return this;
            }

            public CycleSourceOrigin Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<NoneOriginCase, NoneOrigin>))]
        private sealed class NoneOriginCase : ImageOrigin, ICaseValue<NoneOriginCase, NoneOrigin>
        {
            public NoneOrigin _value;

            public override T Match<T>(
                Func<DockerHubOrigin, T> dockerHubOrigin,
                Func<DockerFileOrigin, T> dockerFileOrigin,
                Func<DockerRegistryOrigin, T> dockerRegistryOrigin,
                Func<OciRegistryOrigin, T> ociRegistryOrigin,
                Func<CycleUploadOrigin, T> cycleUploadOrigin,
                Func<CycleSourceOrigin, T> cycleSourceOrigin,
                Func<NoneOrigin, T> noneOrigin)
            {
                return noneOrigin(_value);
            }

            public NoneOriginCase Set(NoneOrigin value)
            {
                _value = value;
                return this;
            }

            public NoneOrigin Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}