// wwwroot/js/scripts.js
document.addEventListener("DOMContentLoaded", function () {
    const tableBody = document.querySelector("#data-table tbody");

    // Fungsi untuk mengambil data dari API
    async function fetchData() {
        try {
            const response = await fetch('/api/data');
            const data = await response.json();
            data.forEach(item => {
                const row = document.createElement('tr');
                row.innerHTML = `
                    <td>${item.nama}</td>
                    <td>${item.jabatan}</td>
                    <td>${item.gaji}</td>
                `;
                tableBody.appendChild(row);
            });
        } catch (error) {
            console.error("Error fetching data:", error);
        }
    }

    fetchData();
});
