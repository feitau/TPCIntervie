/*
The simple Mocha test. 

Write a simple function that returns the string 'hello' and is visible in in hello-test.js
*/
function Hello() {
    return "Hello";
}

exports.sayHello = function () {
    return Hello();
};