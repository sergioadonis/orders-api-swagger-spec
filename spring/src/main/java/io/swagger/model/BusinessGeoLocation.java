package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * BusinessGeoLocation
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.languages.SpringCodegen", date = "2019-12-06T19:20:21.831Z")

public class BusinessGeoLocation   {
  @JsonProperty("latitud")
  private Integer latitud = null;

  @JsonProperty("longitud")
  private Integer longitud = null;

  public BusinessGeoLocation latitud(Integer latitud) {
    this.latitud = latitud;
    return this;
  }

  /**
   * Get latitud
   * @return latitud
  **/
  @ApiModelProperty(value = "")


  public Integer getLatitud() {
    return latitud;
  }

  public void setLatitud(Integer latitud) {
    this.latitud = latitud;
  }

  public BusinessGeoLocation longitud(Integer longitud) {
    this.longitud = longitud;
    return this;
  }

  /**
   * Get longitud
   * @return longitud
  **/
  @ApiModelProperty(value = "")


  public Integer getLongitud() {
    return longitud;
  }

  public void setLongitud(Integer longitud) {
    this.longitud = longitud;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BusinessGeoLocation businessGeoLocation = (BusinessGeoLocation) o;
    return Objects.equals(this.latitud, businessGeoLocation.latitud) &&
        Objects.equals(this.longitud, businessGeoLocation.longitud);
  }

  @Override
  public int hashCode() {
    return Objects.hash(latitud, longitud);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BusinessGeoLocation {\n");
    
    sb.append("    latitud: ").append(toIndentedString(latitud)).append("\n");
    sb.append("    longitud: ").append(toIndentedString(longitud)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

