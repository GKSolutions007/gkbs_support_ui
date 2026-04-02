// Global Configuration for Toastr
// This makes the snackbars look professional
toastr.options = {
    "closeButton": true,         // Show an 'X' to close
    "progressBar": true,         // Show the timing bar at the bottom
    "positionClass": "toast-top-right", // Top right corner
    "timeOut": "3000",           // disappear after 3 seconds
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
};

// Use this for successful actions (like Login, Saving, Updating)
function showSuccessSnackbar(message) {
    toastr.success(message, 'Success');
}

// Use this for failures (like Invalid Password, Server Error)
function showErrorSnackbar(message) {
    toastr.error(message, 'Error');
}

// Use this for warnings
function showWarningSnackbar(message) {
    toastr.warning(message, 'Warning');
}