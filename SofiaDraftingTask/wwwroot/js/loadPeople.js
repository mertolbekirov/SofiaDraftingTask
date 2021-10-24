window.onload = function() {
    var btn = document.getElementById("loadPeople");
    var busyIndicator = document.getElementById("busyIndicator");

    btn.addEventListener("click", getPeopleJson);

    function getPeopleJson() {
        btn.classList.add("d-none"); //remove button from sight
        busyIndicator.classList.remove("d-none"); //gets busy indicator in sight
        $.getJSON("/api/GetPeople", data => loadTable(data));
    }

    function loadTable(data) {
        var table = document.getElementById("peopleTable");
        var thead = document.createElement("thead");
        var tr = document.createElement("tr");
        var thName = document.createElement("th");
        thName.innerText = "Name";
        var thSurname = document.createElement("th");
        thSurname.innerText = "Surname";
        var thLocation = document.createElement("th");
        thLocation.innerText = "Location"
        var thEmail = document.createElement("th");
        thEmail.innerText = "Email";
        tr.appendChild(thName);
        tr.appendChild(thSurname);
        tr.appendChild(thLocation);
        tr.appendChild(thEmail);
        thead.appendChild(tr);

        busyIndicator.classList.add("d-none"); //put a breakpoint here in the browser if you want to see the indicator (table loads too fast to see)

        table.appendChild(thead);
        var tbody = document.createElement("tbody");
        table.appendChild(tbody);
        data.forEach(person => {
            var currTr = document.createElement("tr");
            var tdName = document.createElement("td");
            var tdSurname = document.createElement("td");
            var tdLocation = document.createElement("td");
            var tdEmail = document.createElement("td");

            tdName.innerText = person.name;
            tdSurname.innerText = person.surname;
            tdLocation.innerText = person.location;
            tdEmail.innerText = person.email;

            currTr.appendChild(tdName);
            currTr.appendChild(tdSurname);
            currTr.appendChild(tdLocation);
            currTr.appendChild(tdEmail);

            tbody.appendChild(currTr);
        });
    }
}
