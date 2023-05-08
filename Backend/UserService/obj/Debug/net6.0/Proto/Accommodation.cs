// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/accommodation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace UserService {

  /// <summary>Holder for reflection information generated from Proto/accommodation.proto</summary>
  public static partial class AccommodationReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/accommodation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccommodationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQcm90by9hY2NvbW1vZGF0aW9uLnByb3RvEgtVc2VyU2VydmljZSIiChRB",
            "Y2NvbW1vZGF0aW9uUmVxdWVzdBIKCgJJZBgBIAEoCSK4AQoVQWNjb21tb2Rh",
            "dGlvblJlc3BvbnNlEgwKBG5hbWUYASABKAkSEAoIbG9jYXRpb24YAiABKAkS",
            "EgoKZmFjaWxpdGllcxgDIAMoCRIOCgZwaG90b3MYBCABKAkSEwoLbWluQ2Fw",
            "YWNpdHkYBSABKAUSEwoLbWF4Q2FwYWNpdHkYBiABKAUSDQoFcHJpY2UYCSAB",
            "KAESEwoLcmVzZXJ2YXRpb24YCiABKAgSDQoFZ3JhZGUYCyABKAEycgoRQWNj",
            "b21tb2RhdGlvbkdycGMSXQoUR2V0QWNjb21tb2RhdGlvbkluZm8SIS5Vc2Vy",
            "U2VydmljZS5BY2NvbW1vZGF0aW9uUmVxdWVzdBoiLlVzZXJTZXJ2aWNlLkFj",
            "Y29tbW9kYXRpb25SZXNwb25zZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::UserService.AccommodationRequest), global::UserService.AccommodationRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UserService.AccommodationResponse), global::UserService.AccommodationResponse.Parser, new[]{ "Name", "Location", "Facilities", "Photos", "MinCapacity", "MaxCapacity", "Price", "Reservation", "Grade" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AccommodationRequest : pb::IMessage<AccommodationRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccommodationRequest> _parser = new pb::MessageParser<AccommodationRequest>(() => new AccommodationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccommodationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UserService.AccommodationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationRequest(AccommodationRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationRequest Clone() {
      return new AccommodationRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccommodationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccommodationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AccommodationRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AccommodationResponse : pb::IMessage<AccommodationResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AccommodationResponse> _parser = new pb::MessageParser<AccommodationResponse>(() => new AccommodationResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AccommodationResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UserService.AccommodationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationResponse(AccommodationResponse other) : this() {
      name_ = other.name_;
      location_ = other.location_;
      facilities_ = other.facilities_.Clone();
      photos_ = other.photos_;
      minCapacity_ = other.minCapacity_;
      maxCapacity_ = other.maxCapacity_;
      price_ = other.price_;
      reservation_ = other.reservation_;
      grade_ = other.grade_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationResponse Clone() {
      return new AccommodationResponse(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 2;
    private string location_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "facilities" field.</summary>
    public const int FacilitiesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_facilities_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> facilities_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Facilities {
      get { return facilities_; }
    }

    /// <summary>Field number for the "photos" field.</summary>
    public const int PhotosFieldNumber = 4;
    private string photos_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Photos {
      get { return photos_; }
      set {
        photos_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "minCapacity" field.</summary>
    public const int MinCapacityFieldNumber = 5;
    private int minCapacity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MinCapacity {
      get { return minCapacity_; }
      set {
        minCapacity_ = value;
      }
    }

    /// <summary>Field number for the "maxCapacity" field.</summary>
    public const int MaxCapacityFieldNumber = 6;
    private int maxCapacity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxCapacity {
      get { return maxCapacity_; }
      set {
        maxCapacity_ = value;
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 9;
    private double price_;
    /// <summary>
    ///google.type.Date startDate = 7;
    ///google.type.Date endDate = 8;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 10;
    private bool reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "grade" field.</summary>
    public const int GradeFieldNumber = 11;
    private double grade_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Grade {
      get { return grade_; }
      set {
        grade_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AccommodationResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AccommodationResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Location != other.Location) return false;
      if(!facilities_.Equals(other.facilities_)) return false;
      if (Photos != other.Photos) return false;
      if (MinCapacity != other.MinCapacity) return false;
      if (MaxCapacity != other.MaxCapacity) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Price, other.Price)) return false;
      if (Reservation != other.Reservation) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Grade, other.Grade)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Location.Length != 0) hash ^= Location.GetHashCode();
      hash ^= facilities_.GetHashCode();
      if (Photos.Length != 0) hash ^= Photos.GetHashCode();
      if (MinCapacity != 0) hash ^= MinCapacity.GetHashCode();
      if (MaxCapacity != 0) hash ^= MaxCapacity.GetHashCode();
      if (Price != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Price);
      if (Reservation != false) hash ^= Reservation.GetHashCode();
      if (Grade != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Grade);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Location);
      }
      facilities_.WriteTo(output, _repeated_facilities_codec);
      if (Photos.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Photos);
      }
      if (MinCapacity != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MinCapacity);
      }
      if (MaxCapacity != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MaxCapacity);
      }
      if (Price != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Price);
      }
      if (Reservation != false) {
        output.WriteRawTag(80);
        output.WriteBool(Reservation);
      }
      if (Grade != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(Grade);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Location);
      }
      facilities_.WriteTo(ref output, _repeated_facilities_codec);
      if (Photos.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Photos);
      }
      if (MinCapacity != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MinCapacity);
      }
      if (MaxCapacity != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MaxCapacity);
      }
      if (Price != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Price);
      }
      if (Reservation != false) {
        output.WriteRawTag(80);
        output.WriteBool(Reservation);
      }
      if (Grade != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(Grade);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      size += facilities_.CalculateSize(_repeated_facilities_codec);
      if (Photos.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Photos);
      }
      if (MinCapacity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinCapacity);
      }
      if (MaxCapacity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxCapacity);
      }
      if (Price != 0D) {
        size += 1 + 8;
      }
      if (Reservation != false) {
        size += 1 + 1;
      }
      if (Grade != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AccommodationResponse other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Location.Length != 0) {
        Location = other.Location;
      }
      facilities_.Add(other.facilities_);
      if (other.Photos.Length != 0) {
        Photos = other.Photos;
      }
      if (other.MinCapacity != 0) {
        MinCapacity = other.MinCapacity;
      }
      if (other.MaxCapacity != 0) {
        MaxCapacity = other.MaxCapacity;
      }
      if (other.Price != 0D) {
        Price = other.Price;
      }
      if (other.Reservation != false) {
        Reservation = other.Reservation;
      }
      if (other.Grade != 0D) {
        Grade = other.Grade;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Location = input.ReadString();
            break;
          }
          case 26: {
            facilities_.AddEntriesFrom(input, _repeated_facilities_codec);
            break;
          }
          case 34: {
            Photos = input.ReadString();
            break;
          }
          case 40: {
            MinCapacity = input.ReadInt32();
            break;
          }
          case 48: {
            MaxCapacity = input.ReadInt32();
            break;
          }
          case 73: {
            Price = input.ReadDouble();
            break;
          }
          case 80: {
            Reservation = input.ReadBool();
            break;
          }
          case 89: {
            Grade = input.ReadDouble();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Location = input.ReadString();
            break;
          }
          case 26: {
            facilities_.AddEntriesFrom(ref input, _repeated_facilities_codec);
            break;
          }
          case 34: {
            Photos = input.ReadString();
            break;
          }
          case 40: {
            MinCapacity = input.ReadInt32();
            break;
          }
          case 48: {
            MaxCapacity = input.ReadInt32();
            break;
          }
          case 73: {
            Price = input.ReadDouble();
            break;
          }
          case 80: {
            Reservation = input.ReadBool();
            break;
          }
          case 89: {
            Grade = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
