// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const calenderCell = document.querySelector(".calender-day-cell");
let selectedCell = null;


function calendarCellClicked(cell) {
    if (selectedCell !== null) {
 
        selectedCell.style.backgroundColor = "";
    }


    cell.style.backgroundColor = "green";
    selectedCell = cell;
}

document.getElementById('prevButton').addEventListener('click', function () {
    let getSelectedEstate = document.getElementById('SelectedEstate').textContent;
    let url = `/Home/TogglePreviousEstate?selectedEstate=${getSelectedEstate}`;
    window.location.href = url;
});

document.getElementById('nextButton').addEventListener('click', function () {
    let getSelectedEstate = document.getElementById('SelectedEstate').textContent;
    let url = `/Home/ToggleNextEstate?selectedEstate=${getSelectedEstate}`;
    window.location.href = url;
});