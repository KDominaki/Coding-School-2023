// JavaScript source code

//Ex 1

function reverseString() {
    var s = document.getElementById("string-to-reverse").value;
    var reversedS = s.split("").reverse().join("");
    document.getElementById("reversed-string").value = reversedS;
    document.getElementById("string-to-reverse").value = "";

}
function demo() {
    document.getElementById("test").value = "New text";
}


//Ex 2
function checkPalindrome(word){
    var reverseWord = reverseString(word).toLowerCase();
    if (word.toLowerCase() == reverseWord) {
        console.log("Palindrome")
    }
    else {
        console.log("Not a Palindrome")
    }
}

//Ex 3

//Ex 4
function multiply(a, b) {
    if (a == Number & b == Number) {
        return a * b
    }
    else {
        alert("Non valid input");
    }
}

// Ex 5