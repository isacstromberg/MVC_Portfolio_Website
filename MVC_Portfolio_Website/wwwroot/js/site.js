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