using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Audio : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The title of the album for this audio file.</summary>
        public string Album {
            get { return BackingStore?.Get<string>("album"); }
            set { BackingStore?.Set("album", value); }
        }
        /// <summary>The artist named on the album for the audio file.</summary>
        public string AlbumArtist {
            get { return BackingStore?.Get<string>("albumArtist"); }
            set { BackingStore?.Set("albumArtist", value); }
        }
        /// <summary>The performing artist for the audio file.</summary>
        public string Artist {
            get { return BackingStore?.Get<string>("artist"); }
            set { BackingStore?.Set("artist", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Bitrate expressed in kbps.</summary>
        public long? Bitrate {
            get { return BackingStore?.Get<long?>("bitrate"); }
            set { BackingStore?.Set("bitrate", value); }
        }
        /// <summary>The name of the composer of the audio file.</summary>
        public string Composers {
            get { return BackingStore?.Get<string>("composers"); }
            set { BackingStore?.Set("composers", value); }
        }
        /// <summary>Copyright information for the audio file.</summary>
        public string Copyright {
            get { return BackingStore?.Get<string>("copyright"); }
            set { BackingStore?.Set("copyright", value); }
        }
        /// <summary>The number of the disc this audio file came from.</summary>
        public int? Disc {
            get { return BackingStore?.Get<int?>("disc"); }
            set { BackingStore?.Set("disc", value); }
        }
        /// <summary>The total number of discs in this album.</summary>
        public int? DiscCount {
            get { return BackingStore?.Get<int?>("discCount"); }
            set { BackingStore?.Set("discCount", value); }
        }
        /// <summary>Duration of the audio file, expressed in milliseconds</summary>
        public long? Duration {
            get { return BackingStore?.Get<long?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>The genre of this audio file.</summary>
        public string Genre {
            get { return BackingStore?.Get<string>("genre"); }
            set { BackingStore?.Set("genre", value); }
        }
        /// <summary>Indicates if the file is protected with digital rights management.</summary>
        public bool? HasDrm {
            get { return BackingStore?.Get<bool?>("hasDrm"); }
            set { BackingStore?.Set("hasDrm", value); }
        }
        /// <summary>Indicates if the file is encoded with a variable bitrate.</summary>
        public bool? IsVariableBitrate {
            get { return BackingStore?.Get<bool?>("isVariableBitrate"); }
            set { BackingStore?.Set("isVariableBitrate", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The title of the audio file.</summary>
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
        /// <summary>The number of the track on the original disc for this audio file.</summary>
        public int? Track {
            get { return BackingStore?.Get<int?>("track"); }
            set { BackingStore?.Set("track", value); }
        }
        /// <summary>The total number of tracks on the original disc for this audio file.</summary>
        public int? TrackCount {
            get { return BackingStore?.Get<int?>("trackCount"); }
            set { BackingStore?.Set("trackCount", value); }
        }
        /// <summary>The year the audio file was recorded.</summary>
        public int? Year {
            get { return BackingStore?.Get<int?>("year"); }
            set { BackingStore?.Set("year", value); }
        }
        /// <summary>
        /// Instantiates a new audio and sets the default values.
        /// </summary>
        public Audio() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Audio CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Audio();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"album", n => { Album = n.GetStringValue(); } },
                {"albumArtist", n => { AlbumArtist = n.GetStringValue(); } },
                {"artist", n => { Artist = n.GetStringValue(); } },
                {"bitrate", n => { Bitrate = n.GetLongValue(); } },
                {"composers", n => { Composers = n.GetStringValue(); } },
                {"copyright", n => { Copyright = n.GetStringValue(); } },
                {"disc", n => { Disc = n.GetIntValue(); } },
                {"discCount", n => { DiscCount = n.GetIntValue(); } },
                {"duration", n => { Duration = n.GetLongValue(); } },
                {"genre", n => { Genre = n.GetStringValue(); } },
                {"hasDrm", n => { HasDrm = n.GetBoolValue(); } },
                {"isVariableBitrate", n => { IsVariableBitrate = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"track", n => { Track = n.GetIntValue(); } },
                {"trackCount", n => { TrackCount = n.GetIntValue(); } },
                {"year", n => { Year = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("album", Album);
            writer.WriteStringValue("albumArtist", AlbumArtist);
            writer.WriteStringValue("artist", Artist);
            writer.WriteLongValue("bitrate", Bitrate);
            writer.WriteStringValue("composers", Composers);
            writer.WriteStringValue("copyright", Copyright);
            writer.WriteIntValue("disc", Disc);
            writer.WriteIntValue("discCount", DiscCount);
            writer.WriteLongValue("duration", Duration);
            writer.WriteStringValue("genre", Genre);
            writer.WriteBoolValue("hasDrm", HasDrm);
            writer.WriteBoolValue("isVariableBitrate", IsVariableBitrate);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("title", Title);
            writer.WriteIntValue("track", Track);
            writer.WriteIntValue("trackCount", TrackCount);
            writer.WriteIntValue("year", Year);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}