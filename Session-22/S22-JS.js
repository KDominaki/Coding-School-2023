// JavaScript source code

//Ex 1

function reverseString() {
    var s = document.getElementById("string-to-reverse").value;
    var reversedS = s.split("").reverse().join("");
    document.getElementById("reversed-string").value = reversedS;
    document.getElementById("string-to-reverse").value = "";

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
function exFive(x) {
    var nums = "";
    var letters = ""
    for (let i = 0; i < x.length; i++) {
        if (isNaN(x[i]) == false) {
            nums += x[i];
        }
        else {
            letters += x[i];
        }
    }
    if (nums != "") {
        var numbers = Number(nums);
        numbers += 1
        x = letters += numbers.toString();

    }
    else {
        x = letters += "1";
    }
    return x;
}
console.log(exFive("fjfh56"))

