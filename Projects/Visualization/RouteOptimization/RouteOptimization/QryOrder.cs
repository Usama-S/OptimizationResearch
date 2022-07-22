//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RouteOptimization
{
    using System;
    using System.Collections.Generic;
    
    public partial class QryOrder
    {
        public int order_id { get; set; }
        public int store_id { get; set; }
        public string store_name { get; set; }
        public string store_latitude { get; set; }
        public string store_longitude { get; set; }
        public Nullable<decimal> hub_id { get; set; }
        public string hub_name { get; set; }
        public string hub_city { get; set; }
        public string hub_state { get; set; }
        public Nullable<double> hub_latitude { get; set; }
        public Nullable<double> hub_longitude { get; set; }
        public decimal delivery_id { get; set; }
        public string delivery_distance_meters { get; set; }
        public string delivery_status { get; set; }
        public Nullable<decimal> driver_id { get; set; }
        public Nullable<double> current_latitude { get; set; }
        public Nullable<double> current_longitude { get; set; }
        public Nullable<short> driver_rating { get; set; }
        public Nullable<short> current_orders { get; set; }
        public string order_status { get; set; }
        public int order_created_hour { get; set; }
        public int order_created_minute { get; set; }
        public int order_created_day { get; set; }
        public int order_created_month { get; set; }
        public int order_created_year { get; set; }
        public string order_moment_created { get; set; }
        public string order_moment_accepted { get; set; }
        public string order_moment_ready { get; set; }
        public string order_moment_in_expedition { get; set; }
        public string order_moment_collected { get; set; }
        public string order_moment_delivering { get; set; }
        public string order_moment_delivered { get; set; }
        public string order_moment_finished { get; set; }
        public Nullable<double> order_metric_collected_time { get; set; }
        public Nullable<double> order_metric_paused_time { get; set; }
        public Nullable<double> order_metric_production_time { get; set; }
        public Nullable<double> order_metric_walking_time { get; set; }
        public Nullable<double> order_metric_expediton_speed_time { get; set; }
        public Nullable<double> order_metric_transit_time { get; set; }
        public Nullable<double> order_metric_cycle_time { get; set; }
    }
}