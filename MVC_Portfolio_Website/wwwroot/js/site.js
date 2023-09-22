// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const calenderCell = document.querySelector(".calender-day-cell");
let selectedCell = null;


//Send the first day in current year and the current date to SavePdfMonth.
function calendarCellClicked(cell) {
    if (selectedCell !== null) {
        // Återställ bakgrundsfärgen för den tidigare markerade cellen
        selectedCell.style.backgroundColor = "";
    }

    // Markera den nya cellen och uppdatera selectedCell-variabeln
    cell.style.backgroundColor = "green";
    selectedCell = cell;
}