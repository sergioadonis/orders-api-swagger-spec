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
@javax.annotation.Generated(value = "io.swagger.codegen.languages.SpringCodegen", date = "2019-12-06T05:39:09.551Z")

@Controller
public class BusinessApiController implements BusinessApi {

    private static final Logger log = LoggerFactory.getLogger(BusinessApiController.class);

    private final ObjectMapper objectMapper;

    private final HttpServletRequest request;

    @org.springframework.beans.factory.annotation.Autowired
    public BusinessApiController(ObjectMapper objectMapper, HttpServletRequest request) {
        this.objectMapper = objectMapper;
        this.request = request;
    }

    public ResponseEntity<Business> createBusiness(@ApiParam(value = "" ,required=true )  @Valid @RequestBody Business bussines) {
        String accept = request.getHeader("Accept");
        if (accept != null && accept.contains("application/json")) {
            try {
                return new ResponseEntity<Business>(objectMapper.readValue("{  \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",  \"name\" : \"El Zócalo\",  \"description\" : \"Restaurante de comida mexicana, tequila, karaoke y mucho más!\",  \"id\" : \"12ea34-651d76c-87bd-85b6f9\",  \"category\" : \"Mexican restaurant\",  \"type\" : \"RSTRNT\",  \"tags\" : [ \"Mexican food\", \"Karaoke\", \"Tacos\", \"Tequila\" ]}", Business.class), HttpStatus.NOT_IMPLEMENTED);
            } catch (IOException e) {
                log.error("Couldn't serialize response for content type application/json", e);
                return new ResponseEntity<Business>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        }

        return new ResponseEntity<Business>(HttpStatus.NOT_IMPLEMENTED);
    }

    public ResponseEntity<Void> deleteBusinessById(@ApiParam(value = "",required=true) @PathVariable("id") String id) {
        String accept = request.getHeader("Accept");
        return new ResponseEntity<Void>(HttpStatus.NOT_IMPLEMENTED);
    }

    public ResponseEntity<Business> getBusinessById(@ApiParam(value = "",required=true) @PathVariable("id") String id) {
        String accept = request.getHeader("Accept");
        if (accept != null && accept.contains("application/json")) {
            try {
                return new ResponseEntity<Business>(objectMapper.readValue("{  \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",  \"name\" : \"El Zócalo\",  \"description\" : \"Restaurante de comida mexicana, tequila, karaoke y mucho más!\",  \"id\" : \"12ea34-651d76c-87bd-85b6f9\",  \"category\" : \"Mexican restaurant\",  \"type\" : \"RSTRNT\",  \"tags\" : [ \"Mexican food\", \"Karaoke\", \"Tacos\", \"Tequila\" ]}", Business.class), HttpStatus.NOT_IMPLEMENTED);
            } catch (IOException e) {
                log.error("Couldn't serialize response for content type application/json", e);
                return new ResponseEntity<Business>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        }

        return new ResponseEntity<Business>(HttpStatus.NOT_IMPLEMENTED);
    }

    public ResponseEntity<List<Business>> getBusinesses() {
        String accept = request.getHeader("Accept");
        if (accept != null && accept.contains("application/json")) {
            try {
                return new ResponseEntity<List<Business>>(objectMapper.readValue("[ {  \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",  \"name\" : \"El Zócalo\",  \"description\" : \"Restaurante de comida mexicana, tequila, karaoke y mucho más!\",  \"id\" : \"12ea34-651d76c-87bd-85b6f9\",  \"category\" : \"Mexican restaurant\",  \"type\" : \"RSTRNT\",  \"tags\" : [ \"Mexican food\", \"Karaoke\", \"Tacos\", \"Tequila\" ]}, {  \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",  \"name\" : \"El Zócalo\",  \"description\" : \"Restaurante de comida mexicana, tequila, karaoke y mucho más!\",  \"id\" : \"12ea34-651d76c-87bd-85b6f9\",  \"category\" : \"Mexican restaurant\",  \"type\" : \"RSTRNT\",  \"tags\" : [ \"Mexican food\", \"Karaoke\", \"Tacos\", \"Tequila\" ]} ]", List.class), HttpStatus.NOT_IMPLEMENTED);
            } catch (IOException e) {
                log.error("Couldn't serialize response for content type application/json", e);
                return new ResponseEntity<List<Business>>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        }

        return new ResponseEntity<List<Business>>(HttpStatus.NOT_IMPLEMENTED);
    }

    public ResponseEntity<Business> updateBusinessById(@ApiParam(value = "",required=true) @PathVariable("id") String id,@ApiParam(value = "" ,required=true )  @Valid @RequestBody Business bussines) {
        String accept = request.getHeader("Accept");
        if (accept != null && accept.contains("application/json")) {
            try {
                return new ResponseEntity<Business>(objectMapper.readValue("{  \"photoUrl\" : \"https://user-contents.domain.example.com/12ea34-651d76c-87bd-85b6f9\",  \"name\" : \"El Zócalo\",  \"description\" : \"Restaurante de comida mexicana, tequila, karaoke y mucho más!\",  \"id\" : \"12ea34-651d76c-87bd-85b6f9\",  \"category\" : \"Mexican restaurant\",  \"type\" : \"RSTRNT\",  \"tags\" : [ \"Mexican food\", \"Karaoke\", \"Tacos\", \"Tequila\" ]}", Business.class), HttpStatus.NOT_IMPLEMENTED);
            } catch (IOException e) {
                log.error("Couldn't serialize response for content type application/json", e);
                return new ResponseEntity<Business>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        }

        return new ResponseEntity<Business>(HttpStatus.NOT_IMPLEMENTED);
    }

}
