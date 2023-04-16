# JsonTutorial
JSON - JavaScript Object Notation (derived from JS object notation), text format for storing and transporting data
Basics:
Data is stored in key(ONLY strings in double quotes)/value(string, number, object, array, boolean, null) pairs and separated by commas.
Curly braces hold objects.
Square brackets hold arrays.
JSON file type is ".json".
JSON MIME type text is "application/json".

C#:
Serialize and Deserialize by using Newtonsoft.Json.JsonSerializer or Microsoft System.Text.Json
In this Tutorial we will use System.Text.Json

JavaScript:
JavaScript built in function for converting JSON strings into JavaScript objects:
JSON.parse()
JavaScript built in function for converting an object into a JSON string:
JSON.stringify()

JSON examples:
'{"name":"Tom", "age":19, "student":true, "subjects": ["algebra", "geography", "mathematics", "music", "physics"] }'
