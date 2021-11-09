
public class Rootobject
{
    public Links links { get; set; }
    public int element_count { get; set; }
    public Near_Earth_Objects near_earth_objects { get; set; }
}

public class Links
{
    public string next { get; set; }
    public string prev { get; set; }
    public string self { get; set; }
}

public class Near_Earth_Objects
{
    public _20211110[] _20211110 { get; set; }
    public _20211111[] _20211111 { get; set; }
    public _20211112[] _20211112 { get; set; }
    public _20211113[] _20211113 { get; set; }
    public _20211109[] _20211109 { get; set; }
    public _20211114[] _20211114 { get; set; }
    public _20211115[] _20211115 { get; set; }
    public _20211116[] _20211116 { get; set; }
}

public class _20211110
{
    public Links1 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links1
{
    public string self { get; set; }
}

public class Estimated_Diameter
{
    public Kilometers kilometers { get; set; }
    public Meters meters { get; set; }
    public Miles miles { get; set; }
    public Feet feet { get; set; }
}

public class Kilometers
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity relative_velocity { get; set; }
    public Miss_Distance miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}

public class _20211111
{
    public Links2 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter1 estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data1[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links2
{
    public string self { get; set; }
}

public class Estimated_Diameter1
{
    public Kilometers1 kilometers { get; set; }
    public Meters1 meters { get; set; }
    public Miles1 miles { get; set; }
    public Feet1 feet { get; set; }
}

public class Kilometers1
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters1
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles1
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet1
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data1
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity1 relative_velocity { get; set; }
    public Miss_Distance1 miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity1
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance1
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}

public class _20211112
{
    public Links3 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter2 estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data2[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links3
{
    public string self { get; set; }
}

public class Estimated_Diameter2
{
    public Kilometers2 kilometers { get; set; }
    public Meters2 meters { get; set; }
    public Miles2 miles { get; set; }
    public Feet2 feet { get; set; }
}

public class Kilometers2
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters2
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles2
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet2
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data2
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity2 relative_velocity { get; set; }
    public Miss_Distance2 miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity2
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance2
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}

public class _20211113
{
    public Links4 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter3 estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data3[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links4
{
    public string self { get; set; }
}

public class Estimated_Diameter3
{
    public Kilometers3 kilometers { get; set; }
    public Meters3 meters { get; set; }
    public Miles3 miles { get; set; }
    public Feet3 feet { get; set; }
}

public class Kilometers3
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters3
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles3
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet3
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data3
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity3 relative_velocity { get; set; }
    public Miss_Distance3 miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity3
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance3
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}

public class _20211109
{
    public Links5 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter4 estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data4[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links5
{
    public string self { get; set; }
}

public class Estimated_Diameter4
{
    public Kilometers4 kilometers { get; set; }
    public Meters4 meters { get; set; }
    public Miles4 miles { get; set; }
    public Feet4 feet { get; set; }
}

public class Kilometers4
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters4
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles4
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet4
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data4
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity4 relative_velocity { get; set; }
    public Miss_Distance4 miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity4
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance4
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}

public class _20211114
{
    public Links6 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter5 estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data5[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links6
{
    public string self { get; set; }
}

public class Estimated_Diameter5
{
    public Kilometers5 kilometers { get; set; }
    public Meters5 meters { get; set; }
    public Miles5 miles { get; set; }
    public Feet5 feet { get; set; }
}

public class Kilometers5
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters5
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles5
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet5
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data5
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity5 relative_velocity { get; set; }
    public Miss_Distance5 miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity5
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance5
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}

public class _20211115
{
    public Links7 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter6 estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data6[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links7
{
    public string self { get; set; }
}

public class Estimated_Diameter6
{
    public Kilometers6 kilometers { get; set; }
    public Meters6 meters { get; set; }
    public Miles6 miles { get; set; }
    public Feet6 feet { get; set; }
}

public class Kilometers6
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters6
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles6
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet6
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data6
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity6 relative_velocity { get; set; }
    public Miss_Distance6 miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity6
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance6
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}

public class _20211116
{
    public Links8 links { get; set; }
    public string id { get; set; }
    public string neo_reference_id { get; set; }
    public string name { get; set; }
    public string nasa_jpl_url { get; set; }
    public float absolute_magnitude_h { get; set; }
    public Estimated_Diameter7 estimated_diameter { get; set; }
    public bool is_potentially_hazardous_asteroid { get; set; }
    public Close_Approach_Data7[] close_approach_data { get; set; }
    public bool is_sentry_object { get; set; }
}

public class Links8
{
    public string self { get; set; }
}

public class Estimated_Diameter7
{
    public Kilometers7 kilometers { get; set; }
    public Meters7 meters { get; set; }
    public Miles7 miles { get; set; }
    public Feet7 feet { get; set; }
}

public class Kilometers7
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Meters7
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Miles7
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Feet7
{
    public float estimated_diameter_min { get; set; }
    public float estimated_diameter_max { get; set; }
}

public class Close_Approach_Data7
{
    public string close_approach_date { get; set; }
    public string close_approach_date_full { get; set; }
    public long epoch_date_close_approach { get; set; }
    public Relative_Velocity7 relative_velocity { get; set; }
    public Miss_Distance7 miss_distance { get; set; }
    public string orbiting_body { get; set; }
}

public class Relative_Velocity7
{
    public string kilometers_per_second { get; set; }
    public string kilometers_per_hour { get; set; }
    public string miles_per_hour { get; set; }
}

public class Miss_Distance7
{
    public string astronomical { get; set; }
    public string lunar { get; set; }
    public string kilometers { get; set; }
    public string miles { get; set; }
}
