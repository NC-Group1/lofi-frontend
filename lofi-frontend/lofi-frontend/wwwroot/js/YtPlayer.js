let player;
let isPlayerReady = false;

window.initializeYouTubePlayer = (elementId, videoId) => {
    isPlayerReady = false;
    player = new YT.Player(elementId, {
        height: '100%',
        width: '100%',
        videoId: videoId,
        playerVars: {
            'playsinline': 1,
            'controls': 0,
            'disablekb': 1,
            'fs': 0,
            'rel': 0,
            'mute': 0,
        },
        events {
        'onReady': () => {
                isPlayerReady = true;
            }
        }
    });
};

// Global commands Blazor can trigger
window.playYouTubeVideo = () => { if (player) player.playVideo(); };
window.stopYouTubeVideo = () => { if (player) player.pauseVideo(); };
window.resetSeeker = () => { if (player) player.seekTo(0); };
window.loadVideoById = (id) => {
    if (player) {
        if (isPlayerReady) {
            player.loadVideoById(id, 0, "large")
        } else {
            console.warn("Player is not ready yet...")
            setTimeout(() => window.loadVideoById(id), 100)
        }
    }
}