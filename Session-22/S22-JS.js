// JavaScript source code

//Ex 1
function reverseString(s) {
    return s.split("").reverse().join("");
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


//Ex 4
function multiply(a, b) {
    return a * b;
}
// Ex 5