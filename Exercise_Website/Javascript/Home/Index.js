$(function () {
	$.getJSON('/api/workout', function (workoutJsonPayload) {
		$(workoutJsonPayload).each(function (i, item) {
			$('#workouts').append('<li>' + item.Name + '</li>');
		});
	});
});