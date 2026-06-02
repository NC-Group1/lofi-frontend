let player;

window.initializeYouTubePlayer = (elementId, videoId) => {
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
        }
    });
};

// Global commands Blazor can trigger
window.playYouTubeVideo = () => { if (player) player.playVideo(); };
window.stopYouTubeVideo = () => { if (player) player.pauseVideo(); };
window.resetSeeker = () => { if (player) player.seekTo(0); };