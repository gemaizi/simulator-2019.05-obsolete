// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: reference_line_smoother_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class QpSplineSmootherConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public QpSplineSmootherConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(5)]
        public uint spline_order
        {
            get { return __pbn__spline_order ?? 5; }
            set { __pbn__spline_order = value; }
        }
        public bool ShouldSerializespline_order()
        {
            return __pbn__spline_order != null;
        }
        public void Resetspline_order()
        {
            __pbn__spline_order = null;
        }
        private uint? __pbn__spline_order;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(25)]
        public double max_spline_length
        {
            get { return __pbn__max_spline_length ?? 25; }
            set { __pbn__max_spline_length = value; }
        }
        public bool ShouldSerializemax_spline_length()
        {
            return __pbn__max_spline_length != null;
        }
        public void Resetmax_spline_length()
        {
            __pbn__max_spline_length = null;
        }
        private double? __pbn__max_spline_length;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double regularization_weight
        {
            get { return __pbn__regularization_weight ?? 0.1; }
            set { __pbn__regularization_weight = value; }
        }
        public bool ShouldSerializeregularization_weight()
        {
            return __pbn__regularization_weight != null;
        }
        public void Resetregularization_weight()
        {
            __pbn__regularization_weight = null;
        }
        private double? __pbn__regularization_weight;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double second_derivative_weight
        {
            get { return __pbn__second_derivative_weight ?? 0; }
            set { __pbn__second_derivative_weight = value; }
        }
        public bool ShouldSerializesecond_derivative_weight()
        {
            return __pbn__second_derivative_weight != null;
        }
        public void Resetsecond_derivative_weight()
        {
            __pbn__second_derivative_weight = null;
        }
        private double? __pbn__second_derivative_weight;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(100)]
        public double third_derivative_weight
        {
            get { return __pbn__third_derivative_weight ?? 100; }
            set { __pbn__third_derivative_weight = value; }
        }
        public bool ShouldSerializethird_derivative_weight()
        {
            return __pbn__third_derivative_weight != null;
        }
        public void Resetthird_derivative_weight()
        {
            __pbn__third_derivative_weight = null;
        }
        private double? __pbn__third_derivative_weight;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SpiralSmootherConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SpiralSmootherConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double max_deviation
        {
            get { return __pbn__max_deviation ?? 0.1; }
            set { __pbn__max_deviation = value; }
        }
        public bool ShouldSerializemax_deviation()
        {
            return __pbn__max_deviation != null;
        }
        public void Resetmax_deviation()
        {
            __pbn__max_deviation = null;
        }
        private double? __pbn__max_deviation;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(10)]
        public double piecewise_length
        {
            get { return __pbn__piecewise_length ?? 10; }
            set { __pbn__piecewise_length = value; }
        }
        public bool ShouldSerializepiecewise_length()
        {
            return __pbn__piecewise_length != null;
        }
        public void Resetpiecewise_length()
        {
            __pbn__piecewise_length = null;
        }
        private double? __pbn__piecewise_length;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(1000)]
        public uint max_iteration
        {
            get { return __pbn__max_iteration ?? 1000; }
            set { __pbn__max_iteration = value; }
        }
        public bool ShouldSerializemax_iteration()
        {
            return __pbn__max_iteration != null;
        }
        public void Resetmax_iteration()
        {
            __pbn__max_iteration = null;
        }
        private uint? __pbn__max_iteration;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(1e-08)]
        public double opt_tol
        {
            get { return __pbn__opt_tol ?? 1e-08; }
            set { __pbn__opt_tol = value; }
        }
        public bool ShouldSerializeopt_tol()
        {
            return __pbn__opt_tol != null;
        }
        public void Resetopt_tol()
        {
            __pbn__opt_tol = null;
        }
        private double? __pbn__opt_tol;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(1e-06)]
        public double opt_acceptable_tol
        {
            get { return __pbn__opt_acceptable_tol ?? 1e-06; }
            set { __pbn__opt_acceptable_tol = value; }
        }
        public bool ShouldSerializeopt_acceptable_tol()
        {
            return __pbn__opt_acceptable_tol != null;
        }
        public void Resetopt_acceptable_tol()
        {
            __pbn__opt_acceptable_tol = null;
        }
        private double? __pbn__opt_acceptable_tol;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(15)]
        public uint opt_acceptable_iteration
        {
            get { return __pbn__opt_acceptable_iteration ?? 15; }
            set { __pbn__opt_acceptable_iteration = value; }
        }
        public bool ShouldSerializeopt_acceptable_iteration()
        {
            return __pbn__opt_acceptable_iteration != null;
        }
        public void Resetopt_acceptable_iteration()
        {
            __pbn__opt_acceptable_iteration = null;
        }
        private uint? __pbn__opt_acceptable_iteration;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double weight_curve_length
        {
            get { return __pbn__weight_curve_length ?? 1; }
            set { __pbn__weight_curve_length = value; }
        }
        public bool ShouldSerializeweight_curve_length()
        {
            return __pbn__weight_curve_length != null;
        }
        public void Resetweight_curve_length()
        {
            __pbn__weight_curve_length = null;
        }
        private double? __pbn__weight_curve_length;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double weight_kappa
        {
            get { return __pbn__weight_kappa ?? 1; }
            set { __pbn__weight_kappa = value; }
        }
        public bool ShouldSerializeweight_kappa()
        {
            return __pbn__weight_kappa != null;
        }
        public void Resetweight_kappa()
        {
            __pbn__weight_kappa = null;
        }
        private double? __pbn__weight_kappa;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(100)]
        public double weight_dkappa
        {
            get { return __pbn__weight_dkappa ?? 100; }
            set { __pbn__weight_dkappa = value; }
        }
        public bool ShouldSerializeweight_dkappa()
        {
            return __pbn__weight_dkappa != null;
        }
        public void Resetweight_dkappa()
        {
            __pbn__weight_dkappa = null;
        }
        private double? __pbn__weight_dkappa;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CosThetaSmootherConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CosThetaSmootherConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(5)]
        public double max_point_deviation
        {
            get { return __pbn__max_point_deviation ?? 5; }
            set { __pbn__max_point_deviation = value; }
        }
        public bool ShouldSerializemax_point_deviation()
        {
            return __pbn__max_point_deviation != null;
        }
        public void Resetmax_point_deviation()
        {
            __pbn__max_point_deviation = null;
        }
        private double? __pbn__max_point_deviation;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(10000)]
        public int num_of_iteration
        {
            get { return __pbn__num_of_iteration ?? 10000; }
            set { __pbn__num_of_iteration = value; }
        }
        public bool ShouldSerializenum_of_iteration()
        {
            return __pbn__num_of_iteration != null;
        }
        public void Resetnum_of_iteration()
        {
            __pbn__num_of_iteration = null;
        }
        private int? __pbn__num_of_iteration;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(10000)]
        public double weight_cos_included_angle
        {
            get { return __pbn__weight_cos_included_angle ?? 10000; }
            set { __pbn__weight_cos_included_angle = value; }
        }
        public bool ShouldSerializeweight_cos_included_angle()
        {
            return __pbn__weight_cos_included_angle != null;
        }
        public void Resetweight_cos_included_angle()
        {
            __pbn__weight_cos_included_angle = null;
        }
        private double? __pbn__weight_cos_included_angle;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double acceptable_tol
        {
            get { return __pbn__acceptable_tol ?? 0.1; }
            set { __pbn__acceptable_tol = value; }
        }
        public bool ShouldSerializeacceptable_tol()
        {
            return __pbn__acceptable_tol != null;
        }
        public void Resetacceptable_tol()
        {
            __pbn__acceptable_tol = null;
        }
        private double? __pbn__acceptable_tol;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0.2)]
        public double relax
        {
            get { return __pbn__relax ?? 0.2; }
            set { __pbn__relax = value; }
        }
        public bool ShouldSerializerelax()
        {
            return __pbn__relax != null;
        }
        public void Resetrelax()
        {
            __pbn__relax = null;
        }
        private double? __pbn__relax;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0.05)]
        public double reopt_qp_bound
        {
            get { return __pbn__reopt_qp_bound ?? 0.05; }
            set { __pbn__reopt_qp_bound = value; }
        }
        public bool ShouldSerializereopt_qp_bound()
        {
            return __pbn__reopt_qp_bound != null;
        }
        public void Resetreopt_qp_bound()
        {
            __pbn__reopt_qp_bound = null;
        }
        private double? __pbn__reopt_qp_bound;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ReferenceLineSmootherConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ReferenceLineSmootherConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(5)]
        public double max_constraint_interval
        {
            get { return __pbn__max_constraint_interval ?? 5; }
            set { __pbn__max_constraint_interval = value; }
        }
        public bool ShouldSerializemax_constraint_interval()
        {
            return __pbn__max_constraint_interval != null;
        }
        public void Resetmax_constraint_interval()
        {
            __pbn__max_constraint_interval = null;
        }
        private double? __pbn__max_constraint_interval;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double longitudinal_boundary_bound
        {
            get { return __pbn__longitudinal_boundary_bound ?? 1; }
            set { __pbn__longitudinal_boundary_bound = value; }
        }
        public bool ShouldSerializelongitudinal_boundary_bound()
        {
            return __pbn__longitudinal_boundary_bound != null;
        }
        public void Resetlongitudinal_boundary_bound()
        {
            __pbn__longitudinal_boundary_bound = null;
        }
        private double? __pbn__longitudinal_boundary_bound;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double lateral_boundary_bound
        {
            get { return __pbn__lateral_boundary_bound ?? 0.1; }
            set { __pbn__lateral_boundary_bound = value; }
        }
        public bool ShouldSerializelateral_boundary_bound()
        {
            return __pbn__lateral_boundary_bound != null;
        }
        public void Resetlateral_boundary_bound()
        {
            __pbn__lateral_boundary_bound = null;
        }
        private double? __pbn__lateral_boundary_bound;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(500)]
        public uint num_of_total_points
        {
            get { return __pbn__num_of_total_points ?? 500; }
            set { __pbn__num_of_total_points = value; }
        }
        public bool ShouldSerializenum_of_total_points()
        {
            return __pbn__num_of_total_points != null;
        }
        public void Resetnum_of_total_points()
        {
            __pbn__num_of_total_points = null;
        }
        private uint? __pbn__num_of_total_points;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0.2)]
        public double curb_shift
        {
            get { return __pbn__curb_shift ?? 0.2; }
            set { __pbn__curb_shift = value; }
        }
        public bool ShouldSerializecurb_shift()
        {
            return __pbn__curb_shift != null;
        }
        public void Resetcurb_shift()
        {
            __pbn__curb_shift = null;
        }
        private double? __pbn__curb_shift;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(DrivingSide.RIGHT)]
        public DrivingSide driving_side
        {
            get { return __pbn__driving_side ?? DrivingSide.RIGHT; }
            set { __pbn__driving_side = value; }
        }
        public bool ShouldSerializedriving_side()
        {
            return __pbn__driving_side != null;
        }
        public void Resetdriving_side()
        {
            __pbn__driving_side = null;
        }
        private DrivingSide? __pbn__driving_side;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(2)]
        public double wide_lane_threshold_factor
        {
            get { return __pbn__wide_lane_threshold_factor ?? 2; }
            set { __pbn__wide_lane_threshold_factor = value; }
        }
        public bool ShouldSerializewide_lane_threshold_factor()
        {
            return __pbn__wide_lane_threshold_factor != null;
        }
        public void Resetwide_lane_threshold_factor()
        {
            __pbn__wide_lane_threshold_factor = null;
        }
        private double? __pbn__wide_lane_threshold_factor;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(0.5)]
        public double wide_lane_shift_remain_factor
        {
            get { return __pbn__wide_lane_shift_remain_factor ?? 0.5; }
            set { __pbn__wide_lane_shift_remain_factor = value; }
        }
        public bool ShouldSerializewide_lane_shift_remain_factor()
        {
            return __pbn__wide_lane_shift_remain_factor != null;
        }
        public void Resetwide_lane_shift_remain_factor()
        {
            __pbn__wide_lane_shift_remain_factor = null;
        }
        private double? __pbn__wide_lane_shift_remain_factor;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(0.02)]
        public double resolution
        {
            get { return __pbn__resolution ?? 0.02; }
            set { __pbn__resolution = value; }
        }
        public bool ShouldSerializeresolution()
        {
            return __pbn__resolution != null;
        }
        public void Resetresolution()
        {
            __pbn__resolution = null;
        }
        private double? __pbn__resolution;

        [global::ProtoBuf.ProtoMember(20)]
        public QpSplineSmootherConfig qp_spline
        {
            get { return __pbn__SmootherConfig.Is(20) ? ((QpSplineSmootherConfig)__pbn__SmootherConfig.Object) : default(QpSplineSmootherConfig); }
            set { __pbn__SmootherConfig = new global::ProtoBuf.DiscriminatedUnionObject(20, value); }
        }
        public bool ShouldSerializeqp_spline()
        {
            return __pbn__SmootherConfig.Is(20);
        }
        public void Resetqp_spline()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__SmootherConfig, 20);
        }

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__SmootherConfig;

        [global::ProtoBuf.ProtoMember(21)]
        public SpiralSmootherConfig spiral
        {
            get { return __pbn__SmootherConfig.Is(21) ? ((SpiralSmootherConfig)__pbn__SmootherConfig.Object) : default(SpiralSmootherConfig); }
            set { __pbn__SmootherConfig = new global::ProtoBuf.DiscriminatedUnionObject(21, value); }
        }
        public bool ShouldSerializespiral()
        {
            return __pbn__SmootherConfig.Is(21);
        }
        public void Resetspiral()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__SmootherConfig, 21);
        }

        [global::ProtoBuf.ProtoMember(22)]
        public CosThetaSmootherConfig cos_theta
        {
            get { return __pbn__SmootherConfig.Is(22) ? ((CosThetaSmootherConfig)__pbn__SmootherConfig.Object) : default(CosThetaSmootherConfig); }
            set { __pbn__SmootherConfig = new global::ProtoBuf.DiscriminatedUnionObject(22, value); }
        }
        public bool ShouldSerializecos_theta()
        {
            return __pbn__SmootherConfig.Is(22);
        }
        public void Resetcos_theta()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__SmootherConfig, 22);
        }

        [global::ProtoBuf.ProtoContract()]
        public enum DrivingSide
        {
            LEFT = 1,
            RIGHT = 2,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
