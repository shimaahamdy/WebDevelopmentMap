const ajv = require("ajv");
var Ajv = new ajv();//===> var Validator = Ajv.compile(StudentSchema) ===> Validator(data)

//Validators Schema
var StudentSchema = {
    "type":"object",
    "properties":{
        "name":{"type":"string","pattern":"^[a-zA-Z]+$"},
        "dept":{"type":"string","enum":["SD","AI","ES"],"minLength":2,"maxLength":2}
    },
    "required":["name","dept"],
    "minProperties":2,
    "maxProperties":2
}

// var StudentsValidator = Ajv.compile(StudentSchema)
// module.exports = StudentsValidator;

module.exports = Ajv.compile(StudentSchema);