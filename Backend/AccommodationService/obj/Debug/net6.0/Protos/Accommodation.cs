// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/accommodation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtoService {

  /// <summary>Holder for reflection information generated from Protos/accommodation.proto</summary>
  public static partial class AccommodationReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/accommodation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccommodationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQcm90b3MvYWNjb21tb2RhdGlvbi5wcm90bxIMUHJvdG9TZXJ2aWNlGh9n",
            "b29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIiIKFEFjY29tbW9kYXRp",
            "b25SZXF1ZXN0EgoKAklkGAEgASgJItkCChVBY2NvbW1vZGF0aW9uUmVzcG9u",
            "c2USDwoHZGVsZXRlZBgBIAEoCBIMCgRuYW1lGAIgASgJEhAKCGxvY2F0aW9u",
            "GAMgASgJEhIKCmZhY2lsaXRpZXMYBCADKAkSDgoGcGhvdG9zGAUgASgJEhQK",
            "DG1pbl9jYXBhY2l0eRgGIAEoBRIUCgxtYXhfY2FwYWNpdHkYByABKAUSLgoK",
            "c3RhcnRfZGF0ZRgIIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAS",
            "LAoIZW5kX2RhdGUYCSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "Eg0KBXByaWNlGAogASgBEjMKEHJlc2VydmF0aW9uX3R5cGUYCyABKA4yGS5Q",
            "cm90b1NlcnZpY2UuUmVzZXJ2YXRpb24SDQoFZ3JhZGUYDCABKAESDgoGaG9z",
            "dElkGA0gASgJKjgKC1Jlc2VydmF0aW9uEhYKEkFVVE9fQVVUT01BVElDQUxM",
            "WRAAEhEKDVdJVEhfQVBQUk9WQUwQATJ0ChFBY2NvbW1vZGF0aW9uR3JwYxJf",
            "ChRHZXRBY2NvbW1vZGF0aW9uSW5mbxIiLlByb3RvU2VydmljZS5BY2NvbW1v",
            "ZGF0aW9uUmVxdWVzdBojLlByb3RvU2VydmljZS5BY2NvbW1vZGF0aW9uUmVz",
            "cG9uc2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ProtoService.Reservation), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoService.AccommodationRequest), global::ProtoService.AccommodationRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoService.AccommodationResponse), global::ProtoService.AccommodationResponse.Parser, new[]{ "Deleted", "Name", "Location", "Facilities", "Photos", "MinCapacity", "MaxCapacity", "StartDate", "EndDate", "Price", "ReservationType", "Grade", "HostId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Reservation {
    [pbr::OriginalName("AUTO_AUTOMATICALLY")] AutoAutomatically = 0,
    [pbr::OriginalName("WITH_APPROVAL")] WithApproval = 1,
  }

  #endregion

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
      get { return global::ProtoService.AccommodationReflection.Descriptor.MessageTypes[0]; }
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
      get { return global::ProtoService.AccommodationReflection.Descriptor.MessageTypes[1]; }
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
      deleted_ = other.deleted_;
      name_ = other.name_;
      location_ = other.location_;
      facilities_ = other.facilities_.Clone();
      photos_ = other.photos_;
      minCapacity_ = other.minCapacity_;
      maxCapacity_ = other.maxCapacity_;
      startDate_ = other.startDate_ != null ? other.startDate_.Clone() : null;
      endDate_ = other.endDate_ != null ? other.endDate_.Clone() : null;
      price_ = other.price_;
      reservationType_ = other.reservationType_;
      grade_ = other.grade_;
      hostId_ = other.hostId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccommodationResponse Clone() {
      return new AccommodationResponse(this);
    }

    /// <summary>Field number for the "deleted" field.</summary>
    public const int DeletedFieldNumber = 1;
    private bool deleted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Deleted {
      get { return deleted_; }
      set {
        deleted_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
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
    public const int LocationFieldNumber = 3;
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
    public const int FacilitiesFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_facilities_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> facilities_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Facilities {
      get { return facilities_; }
    }

    /// <summary>Field number for the "photos" field.</summary>
    public const int PhotosFieldNumber = 5;
    private string photos_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Photos {
      get { return photos_; }
      set {
        photos_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "min_capacity" field.</summary>
    public const int MinCapacityFieldNumber = 6;
    private int minCapacity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MinCapacity {
      get { return minCapacity_; }
      set {
        minCapacity_ = value;
      }
    }

    /// <summary>Field number for the "max_capacity" field.</summary>
    public const int MaxCapacityFieldNumber = 7;
    private int maxCapacity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxCapacity {
      get { return maxCapacity_; }
      set {
        maxCapacity_ = value;
      }
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 8;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartDate {
      get { return startDate_; }
      set {
        startDate_ = value;
      }
    }

    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 9;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndDate {
      get { return endDate_; }
      set {
        endDate_ = value;
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 10;
    private double price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "reservation_type" field.</summary>
    public const int ReservationTypeFieldNumber = 11;
    private global::ProtoService.Reservation reservationType_ = global::ProtoService.Reservation.AutoAutomatically;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ProtoService.Reservation ReservationType {
      get { return reservationType_; }
      set {
        reservationType_ = value;
      }
    }

    /// <summary>Field number for the "grade" field.</summary>
    public const int GradeFieldNumber = 12;
    private double grade_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Grade {
      get { return grade_; }
      set {
        grade_ = value;
      }
    }

    /// <summary>Field number for the "hostId" field.</summary>
    public const int HostIdFieldNumber = 13;
    private string hostId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HostId {
      get { return hostId_; }
      set {
        hostId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
      if (Deleted != other.Deleted) return false;
      if (Name != other.Name) return false;
      if (Location != other.Location) return false;
      if(!facilities_.Equals(other.facilities_)) return false;
      if (Photos != other.Photos) return false;
      if (MinCapacity != other.MinCapacity) return false;
      if (MaxCapacity != other.MaxCapacity) return false;
      if (!object.Equals(StartDate, other.StartDate)) return false;
      if (!object.Equals(EndDate, other.EndDate)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Price, other.Price)) return false;
      if (ReservationType != other.ReservationType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Grade, other.Grade)) return false;
      if (HostId != other.HostId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Deleted != false) hash ^= Deleted.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Location.Length != 0) hash ^= Location.GetHashCode();
      hash ^= facilities_.GetHashCode();
      if (Photos.Length != 0) hash ^= Photos.GetHashCode();
      if (MinCapacity != 0) hash ^= MinCapacity.GetHashCode();
      if (MaxCapacity != 0) hash ^= MaxCapacity.GetHashCode();
      if (startDate_ != null) hash ^= StartDate.GetHashCode();
      if (endDate_ != null) hash ^= EndDate.GetHashCode();
      if (Price != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Price);
      if (ReservationType != global::ProtoService.Reservation.AutoAutomatically) hash ^= ReservationType.GetHashCode();
      if (Grade != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Grade);
      if (HostId.Length != 0) hash ^= HostId.GetHashCode();
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
      if (Deleted != false) {
        output.WriteRawTag(8);
        output.WriteBool(Deleted);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Location);
      }
      facilities_.WriteTo(output, _repeated_facilities_codec);
      if (Photos.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Photos);
      }
      if (MinCapacity != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MinCapacity);
      }
      if (MaxCapacity != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(MaxCapacity);
      }
      if (startDate_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(StartDate);
      }
      if (endDate_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(EndDate);
      }
      if (Price != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(Price);
      }
      if (ReservationType != global::ProtoService.Reservation.AutoAutomatically) {
        output.WriteRawTag(88);
        output.WriteEnum((int) ReservationType);
      }
      if (Grade != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(Grade);
      }
      if (HostId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(HostId);
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
      if (Deleted != false) {
        output.WriteRawTag(8);
        output.WriteBool(Deleted);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Location);
      }
      facilities_.WriteTo(ref output, _repeated_facilities_codec);
      if (Photos.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Photos);
      }
      if (MinCapacity != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MinCapacity);
      }
      if (MaxCapacity != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(MaxCapacity);
      }
      if (startDate_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(StartDate);
      }
      if (endDate_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(EndDate);
      }
      if (Price != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(Price);
      }
      if (ReservationType != global::ProtoService.Reservation.AutoAutomatically) {
        output.WriteRawTag(88);
        output.WriteEnum((int) ReservationType);
      }
      if (Grade != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(Grade);
      }
      if (HostId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(HostId);
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
      if (Deleted != false) {
        size += 1 + 1;
      }
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
      if (startDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartDate);
      }
      if (endDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndDate);
      }
      if (Price != 0D) {
        size += 1 + 8;
      }
      if (ReservationType != global::ProtoService.Reservation.AutoAutomatically) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReservationType);
      }
      if (Grade != 0D) {
        size += 1 + 8;
      }
      if (HostId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HostId);
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
      if (other.Deleted != false) {
        Deleted = other.Deleted;
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
      if (other.startDate_ != null) {
        if (startDate_ == null) {
          StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartDate.MergeFrom(other.StartDate);
      }
      if (other.endDate_ != null) {
        if (endDate_ == null) {
          EndDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndDate.MergeFrom(other.EndDate);
      }
      if (other.Price != 0D) {
        Price = other.Price;
      }
      if (other.ReservationType != global::ProtoService.Reservation.AutoAutomatically) {
        ReservationType = other.ReservationType;
      }
      if (other.Grade != 0D) {
        Grade = other.Grade;
      }
      if (other.HostId.Length != 0) {
        HostId = other.HostId;
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
          case 8: {
            Deleted = input.ReadBool();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Location = input.ReadString();
            break;
          }
          case 34: {
            facilities_.AddEntriesFrom(input, _repeated_facilities_codec);
            break;
          }
          case 42: {
            Photos = input.ReadString();
            break;
          }
          case 48: {
            MinCapacity = input.ReadInt32();
            break;
          }
          case 56: {
            MaxCapacity = input.ReadInt32();
            break;
          }
          case 66: {
            if (startDate_ == null) {
              StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartDate);
            break;
          }
          case 74: {
            if (endDate_ == null) {
              EndDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndDate);
            break;
          }
          case 81: {
            Price = input.ReadDouble();
            break;
          }
          case 88: {
            ReservationType = (global::ProtoService.Reservation) input.ReadEnum();
            break;
          }
          case 97: {
            Grade = input.ReadDouble();
            break;
          }
          case 106: {
            HostId = input.ReadString();
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
          case 8: {
            Deleted = input.ReadBool();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Location = input.ReadString();
            break;
          }
          case 34: {
            facilities_.AddEntriesFrom(ref input, _repeated_facilities_codec);
            break;
          }
          case 42: {
            Photos = input.ReadString();
            break;
          }
          case 48: {
            MinCapacity = input.ReadInt32();
            break;
          }
          case 56: {
            MaxCapacity = input.ReadInt32();
            break;
          }
          case 66: {
            if (startDate_ == null) {
              StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartDate);
            break;
          }
          case 74: {
            if (endDate_ == null) {
              EndDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndDate);
            break;
          }
          case 81: {
            Price = input.ReadDouble();
            break;
          }
          case 88: {
            ReservationType = (global::ProtoService.Reservation) input.ReadEnum();
            break;
          }
          case 97: {
            Grade = input.ReadDouble();
            break;
          }
          case 106: {
            HostId = input.ReadString();
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
