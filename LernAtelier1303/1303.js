function addExam() {
    const examNameInput = document.getElementById("exam-name");
    const examDateInput = document.getElementById("exam-date");
    const examName = examNameInput.value;
    const examDate = new Date(examDateInput.value);

    if (examName.trim() === "") {
        alert("Bitte den Namen der Prüfung eingeben.");
    } else if (!isNaN(examDate.getTime())) {
        const currentDate = new Date();
        const timeRemaining = examDate - currentDate;
        const daysRemaining = Math.ceil(timeRemaining / (1000 * 60 * 60 * 24));

        const examList = document.getElementById("exam-list");
        const listItem = document.createElement("li");
        listItem.innerHTML = `Prüfung: <strong>${examName}</strong><br>Datum: ${examDate.toLocaleDateString()}, Tage bis zur Prüfung: ${daysRemaining} <button onclick="removeExam(this)">Löschen</button>`;
        examList.appendChild(listItem);

        examNameInput.value = "";
        examDateInput.value = "";
    } else {
        alert("Ungültiges Datum. Bitte ein gültiges Datum eingeben.");
    }
}

function removeExam(button) {
    const listItem = button.parentElement;
    listItem.remove();
}


