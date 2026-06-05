window.pomodoro = {
    playButtonSound: () => {
        const sound = new Audio('assets/button-press.mp3');
        sound.currentTime = 0.5;
        sound.play();
        setTimeout(() => sound.pause(), 300);
    },

    playAlarmSound: () => {
        const alarm = new Audio('assets/alarm.mp3');
        alarm.currentTime = 0;
        alarm.play();
        setTimeout(() => {
            alarm.pause();
            alarm.currentTime = 0;
        }, 5000);
    }
};
