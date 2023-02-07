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
var allPosts = [];
var selectPostRowEl;

function createPostsTableRow(post, tableEl) {
    let rowEl = tableEl.insertRow();

    rowEl.setAttribute('data-id', post.N);

    rowEl.addEventListener('click', (event) => {
        selectPostRow(event.currentTarget);
    });

    let idEl = rowEl.insertCell(0);
    idEl.innerHTML = post.id;

    let titleEl = rowEl.insertCell(1);
    titleEl.innerHTML = post.title;

    let userIdEl = rowEl.insertCell(2);
    userIdEl.innerHTML = post.userId;
}


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


