// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/reservation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtoService2 {

  /// <summary>Holder for reflection information generated from Protos/reservation.proto</summary>
  public static partial class ReservationReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/reservation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQcm90b3MvcmVzZXJ2YXRpb24ucHJvdG8SDVByb3RvU2VydmljZTIaH2dv",
            "b2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8iIAoSUmVzZXJ2YXRpb25S",
            "ZXF1ZXN0EgoKAklkGAEgASgJIvIBChNSZXNlcnZhdGlvblJlc3BvbnNlEhAK",
            "CGNhcGFjaXR5GAEgASgFEi4KCnN0YXJ0X2RhdGUYAiABKAsyGi5nb29nbGUu",
            "cHJvdG9idWYuVGltZXN0YW1wEiwKCGVuZF9kYXRlGAMgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcBIQCghhcHByb3ZlZBgEIAEoCBIPCgdkZWxl",
            "dGVkGAUgASgIEhcKD2FjY29tb2RhdGlvbl9pZBgGIAEoCRIQCghndWVzdF9p",
            "ZBgHIAEoCRIdChVudW1iZXJfb2ZfY2FuY2VsYXRpb24YCCABKAUybgoPUmVz",
            "ZXJ2YXRpb25HcnBjElsKEkdldFJlc2VydmF0aW9uSW5mbxIhLlByb3RvU2Vy",
            "dmljZTIuUmVzZXJ2YXRpb25SZXF1ZXN0GiIuUHJvdG9TZXJ2aWNlMi5SZXNl",
            "cnZhdGlvblJlc3BvbnNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoService2.ReservationRequest), global::ProtoService2.ReservationRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ProtoService2.ReservationResponse), global::ProtoService2.ReservationResponse.Parser, new[]{ "Capacity", "StartDate", "EndDate", "Approved", "Deleted", "AccomodationId", "GuestId", "NumberOfCancelation" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationRequest : pb::IMessage<ReservationRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReservationRequest> _parser = new pb::MessageParser<ReservationRequest>(() => new ReservationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReservationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtoService2.ReservationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReservationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReservationRequest(ReservationRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReservationRequest Clone() {
      return new ReservationRequest(this);
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
      return Equals(other as ReservationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReservationRequest other) {
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
    public void MergeFrom(ReservationRequest other) {
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

  public sealed partial class ReservationResponse : pb::IMessage<ReservationResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReservationResponse> _parser = new pb::MessageParser<ReservationResponse>(() => new ReservationResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReservationResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtoService2.ReservationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReservationResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReservationResponse(ReservationResponse other) : this() {
      capacity_ = other.capacity_;
      startDate_ = other.startDate_ != null ? other.startDate_.Clone() : null;
      endDate_ = other.endDate_ != null ? other.endDate_.Clone() : null;
      approved_ = other.approved_;
      deleted_ = other.deleted_;
      accomodationId_ = other.accomodationId_;
      guestId_ = other.guestId_;
      numberOfCancelation_ = other.numberOfCancelation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReservationResponse Clone() {
      return new ReservationResponse(this);
    }

    /// <summary>Field number for the "capacity" field.</summary>
    public const int CapacityFieldNumber = 1;
    private int capacity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Capacity {
      get { return capacity_; }
      set {
        capacity_ = value;
      }
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 2;
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
    public const int EndDateFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndDate {
      get { return endDate_; }
      set {
        endDate_ = value;
      }
    }

    /// <summary>Field number for the "approved" field.</summary>
    public const int ApprovedFieldNumber = 4;
    private bool approved_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Approved {
      get { return approved_; }
      set {
        approved_ = value;
      }
    }

    /// <summary>Field number for the "deleted" field.</summary>
    public const int DeletedFieldNumber = 5;
    private bool deleted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Deleted {
      get { return deleted_; }
      set {
        deleted_ = value;
      }
    }

    /// <summary>Field number for the "accomodation_id" field.</summary>
    public const int AccomodationIdFieldNumber = 6;
    private string accomodationId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccomodationId {
      get { return accomodationId_; }
      set {
        accomodationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "guest_id" field.</summary>
    public const int GuestIdFieldNumber = 7;
    private string guestId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GuestId {
      get { return guestId_; }
      set {
        guestId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "number_of_cancelation" field.</summary>
    public const int NumberOfCancelationFieldNumber = 8;
    private int numberOfCancelation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NumberOfCancelation {
      get { return numberOfCancelation_; }
      set {
        numberOfCancelation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReservationResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReservationResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Capacity != other.Capacity) return false;
      if (!object.Equals(StartDate, other.StartDate)) return false;
      if (!object.Equals(EndDate, other.EndDate)) return false;
      if (Approved != other.Approved) return false;
      if (Deleted != other.Deleted) return false;
      if (AccomodationId != other.AccomodationId) return false;
      if (GuestId != other.GuestId) return false;
      if (NumberOfCancelation != other.NumberOfCancelation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Capacity != 0) hash ^= Capacity.GetHashCode();
      if (startDate_ != null) hash ^= StartDate.GetHashCode();
      if (endDate_ != null) hash ^= EndDate.GetHashCode();
      if (Approved != false) hash ^= Approved.GetHashCode();
      if (Deleted != false) hash ^= Deleted.GetHashCode();
      if (AccomodationId.Length != 0) hash ^= AccomodationId.GetHashCode();
      if (GuestId.Length != 0) hash ^= GuestId.GetHashCode();
      if (NumberOfCancelation != 0) hash ^= NumberOfCancelation.GetHashCode();
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
      if (Capacity != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Capacity);
      }
      if (startDate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartDate);
      }
      if (endDate_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndDate);
      }
      if (Approved != false) {
        output.WriteRawTag(32);
        output.WriteBool(Approved);
      }
      if (Deleted != false) {
        output.WriteRawTag(40);
        output.WriteBool(Deleted);
      }
      if (AccomodationId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AccomodationId);
      }
      if (GuestId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(GuestId);
      }
      if (NumberOfCancelation != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(NumberOfCancelation);
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
      if (Capacity != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Capacity);
      }
      if (startDate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartDate);
      }
      if (endDate_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EndDate);
      }
      if (Approved != false) {
        output.WriteRawTag(32);
        output.WriteBool(Approved);
      }
      if (Deleted != false) {
        output.WriteRawTag(40);
        output.WriteBool(Deleted);
      }
      if (AccomodationId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AccomodationId);
      }
      if (GuestId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(GuestId);
      }
      if (NumberOfCancelation != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(NumberOfCancelation);
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
      if (Capacity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Capacity);
      }
      if (startDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartDate);
      }
      if (endDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndDate);
      }
      if (Approved != false) {
        size += 1 + 1;
      }
      if (Deleted != false) {
        size += 1 + 1;
      }
      if (AccomodationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccomodationId);
      }
      if (GuestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GuestId);
      }
      if (NumberOfCancelation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumberOfCancelation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReservationResponse other) {
      if (other == null) {
        return;
      }
      if (other.Capacity != 0) {
        Capacity = other.Capacity;
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
      if (other.Approved != false) {
        Approved = other.Approved;
      }
      if (other.Deleted != false) {
        Deleted = other.Deleted;
      }
      if (other.AccomodationId.Length != 0) {
        AccomodationId = other.AccomodationId;
      }
      if (other.GuestId.Length != 0) {
        GuestId = other.GuestId;
      }
      if (other.NumberOfCancelation != 0) {
        NumberOfCancelation = other.NumberOfCancelation;
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
            Capacity = input.ReadInt32();
            break;
          }
          case 18: {
            if (startDate_ == null) {
              StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartDate);
            break;
          }
          case 26: {
            if (endDate_ == null) {
              EndDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndDate);
            break;
          }
          case 32: {
            Approved = input.ReadBool();
            break;
          }
          case 40: {
            Deleted = input.ReadBool();
            break;
          }
          case 50: {
            AccomodationId = input.ReadString();
            break;
          }
          case 58: {
            GuestId = input.ReadString();
            break;
          }
          case 64: {
            NumberOfCancelation = input.ReadInt32();
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
            Capacity = input.ReadInt32();
            break;
          }
          case 18: {
            if (startDate_ == null) {
              StartDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartDate);
            break;
          }
          case 26: {
            if (endDate_ == null) {
              EndDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndDate);
            break;
          }
          case 32: {
            Approved = input.ReadBool();
            break;
          }
          case 40: {
            Deleted = input.ReadBool();
            break;
          }
          case 50: {
            AccomodationId = input.ReadString();
            break;
          }
          case 58: {
            GuestId = input.ReadString();
            break;
          }
          case 64: {
            NumberOfCancelation = input.ReadInt32();
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