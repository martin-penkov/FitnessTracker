// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.'
function multiplyActivityLevel(activityLevel, baseCalorieValue, currentDailyCals) {
    var defaultActivityLevel = 1.4;
    var recommendedCalElement = document.getElementsByClassName("dailyCaldiv")[0];
    recommendedCalElement.innerHTML = (baseCalorieValue / defaultActivityLevel * activityLevel).toFixed(2);

    var remainingCalElement = document.getElementsByClassName("remainingCalories")[0];
    remainingCalElement.innerHTML = Math.round((Number(recommendedCalElement.innerHTML) - currentDailyCals) * 100) / 100;
}

function AddNewDropdown() {
    var mainContainer = document.getElementsByClassName("addExerciseDropdowns")[0]
    var sampleValueHTML = document.getElementsByClassName("sampleValue")[0].innerHTML
    mainContainer.innerHTML += sampleValueHTML
}

function deleteCurrentParent() {

}

function validatePasswordField() {
    var passwordInput = document.getElementsByClassName("registerPasswordInput")[0].value
    if (passwordInput.length < 5) {
        alert("Password does not meet requirements! It should be at least 5 characters long!");
    }
}

function RedirectWorkoutDetails(event) {
    var currentWorkout = event.currentTarget.children[0].innerHTML
    location.href = "../Workout/WorkoutDetails/" + currentWorkout + "?"
}