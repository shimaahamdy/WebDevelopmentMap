const Ajv = require("ajv").default;
var ajv = new Ajv();

userSchema = {

  
    "type": "object",
    "properties": {
        "userID": {"type":"number"},
        "content": {"type": "string"}
  },
  "required": ["userID","content"]
  
}

module.exports = ajv.compile(userSchema);
