var teacher = {
    name : "foo",
    department : "cs"
}

var student = {
    name :"koo",
    age : 8,
    subject : "maths"
}

function SendEmail(){
    console.log(this);
}

SendEmail.apply(teacher);
SendEmail.call(student);