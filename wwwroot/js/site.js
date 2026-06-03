// Active nav link
document.addEventListener('DOMContentLoaded', function () {
    const currentPath = window.location.pathname.toLowerCase();
    document.querySelectorAll('.nav-link').forEach(link => {
        const href = link.getAttribute('href');
        if (href && currentPath.includes(href.toLowerCase().split('/')[1]) && href !== '/') {
            link.classList.add('active');
        }
    });

    // Character counter for textareas
    document.querySelectorAll('textarea').forEach(function (ta) {
        ta.addEventListener('input', function () {
            let counter = ta.nextElementSibling;
            if (counter && counter.classList.contains('char-count')) {
                counter.textContent = ta.value.length + ' karakter';
            }
        });
    });

    // Filter buttons active state
    document.querySelectorAll('.btn-group .btn').forEach(function (btn) {
        btn.addEventListener('click', function () {
            const group = this.closest('.btn-group');
            if (group) {
                group.querySelectorAll('.btn').forEach(b => {
                    b.classList.remove('btn-warning');
                    b.classList.add('btn-outline-secondary');
                });
                this.classList.remove('btn-outline-secondary');
                this.classList.add('btn-warning');
            }
        });
    });

    // Auto-hide alerts after 4 seconds
    document.querySelectorAll('.alert').forEach(function (alert) {
        setTimeout(function () {
            alert.style.transition = 'opacity 0.5s';
            alert.style.opacity = '0';
            setTimeout(() => alert.remove(), 500);
        }, 4000);
    });

    // Confirm delete
    document.querySelectorAll('form[onsubmit]').forEach(function (form) {
        form.addEventListener('submit', function (e) {
            const msg = form.getAttribute('onsubmit');
            if (msg && msg.includes('confirm')) {
                if (!confirm('Bu yemeği silmek istediğinden emin misin?')) {
                    e.preventDefault();
                }
            }
        });
    });
});

// Change paragraph colors to blue (JS DOM lab exercise)
function changeParaColors() {
    document.querySelectorAll('p').forEach(p => p.style.color = 'blue');
}

// Reverse text of all h2 elements (JS lab exercise)
function reverseH2Text() {
    document.querySelectorAll('h2').forEach(h => {
        h.textContent = h.textContent.split('').reverse().join('');
    });
}

// Get even numbers utility
function getEvenNumbers(arr) {
    return arr.filter(n => n % 2 === 0);
}

// Reverse string without built-in reverse
function reverseString(str) {
    let result = '';
    for (let i = str.length - 1; i >= 0; i--) {
        result += str[i];
    }
    return result;
}
