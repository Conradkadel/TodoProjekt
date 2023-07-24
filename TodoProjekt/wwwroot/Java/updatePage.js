(function () {
    window.EmployeeInterop = {
        refreshAufgabenData: () => {
            setInterval(() => {
                document.getElementById("btnGetEmployeeData").click();
            }, 3000);
        }
    };
})();