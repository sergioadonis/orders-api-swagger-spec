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
 * BusinessCategoryStyle
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.languages.SpringCodegen", date = "2019-12-06T19:18:23.260Z")

public class BusinessCategoryStyle   {
  @JsonProperty("iconName")
  private String iconName = null;

  @JsonProperty("baseColor")
  private String baseColor = null;

  @JsonProperty("accentColor")
  private String accentColor = null;

  public BusinessCategoryStyle iconName(String iconName) {
    this.iconName = iconName;
    return this;
  }

  /**
   * Get iconName
   * @return iconName
  **/
  @ApiModelProperty(value = "")


  public String getIconName() {
    return iconName;
  }

  public void setIconName(String iconName) {
    this.iconName = iconName;
  }

  public BusinessCategoryStyle baseColor(String baseColor) {
    this.baseColor = baseColor;
    return this;
  }

  /**
   * Get baseColor
   * @return baseColor
  **/
  @ApiModelProperty(value = "")


  public String getBaseColor() {
    return baseColor;
  }

  public void setBaseColor(String baseColor) {
    this.baseColor = baseColor;
  }

  public BusinessCategoryStyle accentColor(String accentColor) {
    this.accentColor = accentColor;
    return this;
  }

  /**
   * Get accentColor
   * @return accentColor
  **/
  @ApiModelProperty(value = "")


  public String getAccentColor() {
    return accentColor;
  }

  public void setAccentColor(String accentColor) {
    this.accentColor = accentColor;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BusinessCategoryStyle businessCategoryStyle = (BusinessCategoryStyle) o;
    return Objects.equals(this.iconName, businessCategoryStyle.iconName) &&
        Objects.equals(this.baseColor, businessCategoryStyle.baseColor) &&
        Objects.equals(this.accentColor, businessCategoryStyle.accentColor);
  }

  @Override
  public int hashCode() {
    return Objects.hash(iconName, baseColor, accentColor);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BusinessCategoryStyle {\n");
    
    sb.append("    iconName: ").append(toIndentedString(iconName)).append("\n");
    sb.append("    baseColor: ").append(toIndentedString(baseColor)).append("\n");
    sb.append("    accentColor: ").append(toIndentedString(accentColor)).append("\n");
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

