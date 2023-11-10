document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById("logicForm");
    const resultDiv = document.getElementById("result");
    const resultHeader = document.getElementById("resultHeader");

    form.addEventListener("submit", function (e) {
        e.preventDefault();
        calculateLogic();
    });

    // Функция для обновления результата
    function updateResult() {
        calculateLogic();
    }

    // Добавляем обработчики событий для всех полей ввода и операторов
    for (let i = 1; i <= 6; i++) {
        const inputElement = document.getElementById(`input${i}`);
        const operatorElement = document.getElementById(`operator${i}`);

        inputElement.addEventListener("input", updateResult);
        operatorElement.addEventListener("input", updateResult);
    }

    function calculateLogic() {
        const inputs = [];
        const operators = [];

        for (let i = 1; i <= 6; i++) {
            const inputElement = document.getElementById(`input${i}`);
            const operatorElement = document.getElementById(`operator${i}`);

            if (inputElement) {
                // Преобразуем входные значения в логические значения
                const inputValue = inputElement.value.toLowerCase();
                const input = inputValue.toLowerCase() === "true" ? true : false;
                inputs.push(input);
            }

            if (operatorElement) {
                const operator = operatorElement.value;
                operators.push(operator);
            }
        }

        const url = "https://localhost:7083/api/Logic/calculate";

        fetch(url, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({
                Input1: inputs[0],
                Input2: inputs[1],
                Input3: inputs[2],
                Input4: inputs[3],
                Input5: inputs[4],
                Input6: inputs[5],
                Operator1: operators[0],
                Operator2: operators[1],
                Operator3: operators[2],
                Operator4: operators[3],
                Operator5: operators[4]
            })
        })
        .then(response => response.json())
        .then(data => {
            // Отображаем результат на странице
            resultDiv.textContent = `OUTPUT = ${data}`;

            const result = data;

            // Обновляем заголовок в соответствии с результатом
            resultHeader.textContent = `Result: ${result ? "TRUE" : "FALSE"}`;
        })
        .catch(error => {
            console.error("Ошибка при выполнении операции:", error);
            alert("Произошла ошибка при выполнении операции.");
        });
    }
});
