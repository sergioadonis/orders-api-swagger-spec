package io.swagger.api;

import io.swagger.model.Business;
import io.swagger.model.Error;
import com.fasterxml.jackson.databind.ObjectMapper;
import io.swagger.annotations.*;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RequestPart;
import org.springframework.web.multipart.MultipartFile;

import javax.validation.constraints.*;
import javax.validation.Valid;
import javax.servlet.http.HttpServletRequest;
import java.io.IOException;
import java.util.List;
@javax.annotation.Generated(value = "io.swagger.codegen.languages.SpringCodegen", date = "2019-12-06T19:20:21.831Z")

@Controller
public class BusinesscategoryApiController implements BusinesscategoryApi {

    private static final Logger log = LoggerFactory.getLogger(BusinesscategoryApiController.class);

    private final ObjectMapper objectMapper;

    private final HttpServletRequest request;

    @org.springframework.beans.factory.annotation.Autowired
    public BusinesscategoryApiController(ObjectMapper objectMapper, HttpServletRequest request) {
        this.objectMapper = objectMapper;
        this.request = request;
    }

    public ResponseEntity<Business> createBusiness(@ApiParam(value = "" ,required=true )  @Valid @RequestBody Business bussines) {
        String accept = request.getHeader("Accept");
        if (accept != null && accept.contains("application/json")) {
            try {
                return new ResponseEntity<Business>(objectMapper.readValue("{  \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",  \"phoneNumber\" : \"2222-5555\",  \"address\" : \"La direccion del negocio\",  \"geoLocation\" : {    \"latitud\" : 0,    \"longitud\" : 6  },  \"name\" : \"El Zócalo\",  \"description\" : \"Restaurante de comida mexicana, tequila, karaoke y mucho más!\",  \"id\" : \"12ea34-651d76c-87bd-85b6f9\",  \"category\" : {    \"name\" : \"Mexican restaurant\",    \"description\" : \"description\",    \"style\" : {      \"iconName\" : \"iconName\",      \"accentColor\" : \"accentColor\",      \"baseColor\" : \"baseColor\"    },    \"id\" : \"{}\"  },  \"type\" : \"RSTRNT\",  \"tags\" : [ \"Mexican food\", \"Karaoke\", \"Tacos\", \"Tequila\" ]}", Business.class), HttpStatus.NOT_IMPLEMENTED);
            } catch (IOException e) {
                log.error("Couldn't serialize response for content type application/json", e);
                return new ResponseEntity<Business>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        }

        return new ResponseEntity<Business>(HttpStatus.NOT_IMPLEMENTED);
    }

    public ResponseEntity<List<Business>> getBusinesses(@ApiParam(value = "Limit of items in an array to return", defaultValue = "100") @Valid @RequestParam(value = "limit", required = false, defaultValue="100") Integer limit,@ApiParam(value = "Offset to skip in an array to return", defaultValue = "0") @Valid @RequestParam(value = "offset", required = false, defaultValue="0") Integer offset,@ApiParam(value = "") @Valid @RequestParam(value = "category", required = false) String category) {
        String accept = request.getHeader("Accept");
        if (accept != null && accept.contains("application/json")) {
            try {
                return new ResponseEntity<List<Business>>(objectMapper.readValue("[ {  \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",  \"phoneNumber\" : \"2222-5555\",  \"address\" : \"La direccion del negocio\",  \"geoLocation\" : {    \"latitud\" : 0,    \"longitud\" : 6  },  \"name\" : \"El Zócalo\",  \"description\" : \"Restaurante de comida mexicana, tequila, karaoke y mucho más!\",  \"id\" : \"12ea34-651d76c-87bd-85b6f9\",  \"category\" : {    \"name\" : \"Mexican restaurant\",    \"description\" : \"description\",    \"style\" : {      \"iconName\" : \"iconName\",      \"accentColor\" : \"accentColor\",      \"baseColor\" : \"baseColor\"    },    \"id\" : \"{}\"  },  \"type\" : \"RSTRNT\",  \"tags\" : [ \"Mexican food\", \"Karaoke\", \"Tacos\", \"Tequila\" ]}, {  \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",  \"phoneNumber\" : \"2222-5555\",  \"address\" : \"La direccion del negocio\",  \"geoLocation\" : {    \"latitud\" : 0,    \"longitud\" : 6  },  \"name\" : \"El Zócalo\",  \"description\" : \"Restaurante de comida mexicana, tequila, karaoke y mucho más!\",  \"id\" : \"12ea34-651d76c-87bd-85b6f9\",  \"category\" : {    \"name\" : \"Mexican restaurant\",    \"description\" : \"description\",    \"style\" : {      \"iconName\" : \"iconName\",      \"accentColor\" : \"accentColor\",      \"baseColor\" : \"baseColor\"    },    \"id\" : \"{}\"  },  \"type\" : \"RSTRNT\",  \"tags\" : [ \"Mexican food\", \"Karaoke\", \"Tacos\", \"Tequila\" ]} ]", List.class), HttpStatus.NOT_IMPLEMENTED);
            } catch (IOException e) {
                log.error("Couldn't serialize response for content type application/json", e);
                return new ResponseEntity<List<Business>>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        }

        return new ResponseEntity<List<Business>>(HttpStatus.NOT_IMPLEMENTED);
    }

}
