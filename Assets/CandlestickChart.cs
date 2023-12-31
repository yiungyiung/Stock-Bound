using UnityEngine;
using System.Collections.Generic;
using TMPro;
public class CandlestickChart : MonoBehaviour
{
    public GameObject linePrefab; // Assign your LineRenderer prefab in the Inspector
private List<float> openPrices = new List<float> { 3388.0f, 3355.0f, 3459.4f, 3418.0f, 3401.1f, 3380.2f, 3385.0f, 3382.0f, 3290.0f, 3190.0f, 3218.5f, 3240.0f, 3092.0f, 3094.0f, 3130.0f, 3199.9f, 3222.9f, 3339.0f, 3350.0f, 3307.0f, 3271.0f, 3272.0f, 3260.0f, 3312.0f, 3255.0f, 3218.5f, 3271.0f, 3300.0f, 3206.2f, 3114.9f, 3104.0f, 3056.0f, 3018.6f, 3023.0f, 3030.1f, 3107.8f, 3167.0f, 3185.0f, 3171.0f, 3165.0f, 3164.7f, 3115.0f, 3216.0f, 3290.0f, 3327.0f, 3290.0f, 3280.0f, 3350.0f, 3361.2f, 3365.1f, 3365.0f, 3385.0f, 3400.0f, 3419.0f, 3411.0f, 3385.1f, 3390.0f, 3387.0f, 3365.0f, 3319.9f, 3292.0f, 3276.0f, 3234.3f, 3125.0f, 3155.0f, 3190.0f, 3163.0f, 3123.7f, 3135.5f, 3102.0f, 3170.0f, 3195.0f, 3239.9f, 3263.4f, 3135.0f, 3130.0f, 3076.0f, 3036.0f, 3050.0f, 3028.0f, 2990.0f, 3004.0f, 2959.8f, 3009.4f, 2980.0f, 3054.0f, 2990.8f, 3004.6f, 2995.0f, 3029.9f, 3111.0f, 3097.4f, 3010.0f, 3100.0f, 3084.9f, 3100.8f, 3145.0f, 3072.7f, 3150.0f, 3159.0f, 3105.0f, 3157.8f, 3170.1f, 3161.7f, 3180.5f, 3160.7f, 3150.0f, 3199.0f, 3214.5f, 3270.0f, 3228.1f, 3217.0f, 3229.0f, 3249.8f, 3170.0f, 3269.6f, 3315.9f, 3324.0f, 3321.0f, 3338.9f, 3340.0f, 3350.0f, 3322.5f, 3280.0f, 3330.0f, 3316.2f, 3383.0f, 3366.0f, 3383.0f, 3383.0f, 3425.0f, 3458.1f, 3433.0f, 3400.1f, 3368.3f, 3360.0f, 3374.1f, 3255.5f, 3277.2f, 3348.8f, 3358.8f, 3275.0f, 3227.0f, 3198.9f, 3249.0f, 3294.0f, 3217.0f, 3228.3f, 3269.2f, 3249.8f, 3231.1f, 3286.1f, 3261.0f, 3252.0f, 3306.7f, 3330.2f, 3300.0f, 3229.0f, 3285.0f, 3290.1f, 3329.0f, 3342.9f, 3317.0f, 3330.0f, 3380.0f, 3380.0f, 3365.0f, 3388.0f, 3425.0f, 3425.3f, 3426.0f, 3420.0f, 3449.0f, 3363.0f, 3427.0f, 3504.0f, 3473.2f, 3468.9f, 3478.1f, 3515.0f, 3520.0f, 3549.0f, 3505.0f, 3487.0f, 3527.2f, 3526.2f, 3502.0f, 3494.0f, 3414.9f, 3421.0f, 3422.5f, 3390.0f, 3328.5f, 3323.0f, 3361.0f, 3354.0f, 3361.9f, 3364.0f, 3385.0f, 3312.9f, 3333.0f, 3280.0f, 3250.0f, 3208.0f, 3150.5f, 3169.7f, 3143.3f, 3130.1f, 3114.9f, 3148.9f, 3135.0f, 3127.0f, 3129.0f, 3189.9f, 3224.9f, 3185.5f, 3225.0f, 3220.0f, 3264.0f, 3227.9f, 3210.0f, 3134.1f, 3154.9f, 3130.8f, 3090.0f, 3110.0f, 3151.1f, 3183.0f, 3181.0f, 3185.0f, 3200.4f, 3235.0f, 3216.0f, 3180.2f, 3220.0f, 3245.0f, 3252.6f, 3290.0f, 3309.0f, 3279.2f, 3284.0f, 3256.2f, 3255.9f, 3225.9f, 3210.0f, 3230.0f, 3306.0f, 3276.0f, 3294.0f, 3293.5f, 3360.8f, 3315.0f, 3309.0f, 3314.0f, 3326.2f, 3315.0f, 3280.0f, 3253.0f, 3261.0f, 3245.0f, 3215.0f, 3260.0f, 3243.7f, 3245.3f, 3197.0f, 3190.0f, 3214.0f, 3250.0f, 3260.0f, 3237.3f, 3205.0f, 3202.0f, 3208.0f, 3220.0f, 3314.3f, 3290.0f, 3320.0f, 3306.6f, 3302.0f, 3324.8f, 3295.0f, 3280.9f, 3284.0f, 3365.0f, 3514.7f, 3510.0f, 3476.0f, 3500.0f, 3453.1f, 3404.1f, 3381.0f, 3397.5f, 3400.3f, 3394.9f, 3385.0f, 3364.4f, 3415.0f, 3434.9f, 3420.0f, 3401.2f, 3453.9f, 3484.1f, 3464.9f, 3450.0f, 3438.1f, 3440.7f, 3450.0f, 3455.0f, 3410.0f, 3375.0f, 3400.0f, 3388.0f, 3408.0f, 3375.0f, 3394.0f, 3381.1f, 3398.0f, 3401.0f, 3366.0f, 3378.0f, 3420.0f, 3434.0f, 3430.8f, 3455.2f };
private List<float> closePrices = new List<float> { 3355.2f, 3423.0f, 3440.2f, 3430.9f, 3362.7f, 3404.2f, 3427.1f, 3359.9f, 3219.6f, 3210.6f, 3206.3f, 3142.0f, 3088.9f, 3112.4f, 3211.9f, 3222.9f, 3308.8f, 3293.1f, 3314.7f, 3318.2f, 3290.5f, 3267.1f, 3315.1f, 3235.1f, 3216.3f, 3260.8f, 3287.8f, 3265.4f, 3113.8f, 3084.7f, 3038.8f, 2998.8f, 2994.6f, 3063.5f, 3074.2f, 3164.8f, 3177.3f, 3171.0f, 3171.0f, 3166.8f, 3115.9f, 3188.8f, 3260.5f, 3301.9f, 3298.8f, 3291.8f, 3339.5f, 3354.9f, 3365.1f, 3365.1f, 3374.4f, 3354.2f, 3422.5f, 3401.6f, 3392.7f, 3401.1f, 3381.2f, 3385.8f, 3354.6f, 3284.6f, 3255.3f, 3218.2f, 3222.2f, 3132.6f, 3211.2f, 3131.7f, 3130.4f, 3133.4f, 3127.1f, 3149.6f, 3169.7f, 3217.7f, 3242.9f, 3229.3f, 3120.4f, 3104.3f, 3008.7f, 3028.8f, 3040.3f, 3001.2f, 3007.4f, 2982.1f, 2994.4f, 3017.4f, 3035.7f, 2997.3f, 3004.6f, 3004.6f, 2984.9f, 3091.2f, 3101.9f, 3064.9f, 3118.6f, 3069.6f, 3100.8f, 3103.3f, 3099.2f, 3111.8f, 3144.7f, 3121.8f, 3157.3f, 3137.4f, 3161.7f, 3161.7f, 3162.1f, 3157.4f, 3163.2f, 3193.2f, 3259.7f, 3241.7f, 3206.8f, 3217.4f, 3233.7f, 3216.1f, 3205.7f, 3315.9f, 3315.9f, 3335.5f, 3332.6f, 3355.3f, 3349.0f, 3343.4f, 3283.5f, 3314.9f, 3308.3f, 3380.2f, 3389.7f, 3395.2f, 3397.3f, 3390.8f, 3475.7f, 3439.2f, 3425.9f, 3385.3f, 3380.6f, 3350.6f, 3292.8f, 3286.4f, 3332.1f, 3365.3f, 3305.1f, 3240.2f, 3202.1f, 3243.9f, 3268.6f, 3259.7f, 3228.3f, 3252.9f, 3259.5f, 3257.1f, 3268.8f, 3256.7f, 3261.4f, 3311.3f, 3314.7f, 3311.1f, 3211.6f, 3319.9f, 3286.4f, 3328.7f, 3334.3f, 3374.6f, 3334.1f, 3378.4f, 3390.0f, 3373.1f, 3363.1f, 3414.9f, 3436.3f, 3429.8f, 3411.1f, 3433.7f, 3358.7f, 3408.3f, 3460.4f, 3482.3f, 3459.9f, 3472.6f, 3520.1f, 3540.8f, 3537.6f, 3482.4f, 3500.1f, 3520.7f, 3558.1f, 3501.2f, 3487.3f, 3451.0f, 3401.6f, 3413.8f, 3400.4f, 3331.8f, 3312.8f, 3385.7f, 3321.4f, 3342.2f, 3371.8f, 3390.4f, 3336.8f, 3331.0f, 3281.9f, 3214.9f, 3198.9f, 3185.0f, 3179.3f, 3143.3f, 3106.1f, 3130.8f, 3124.7f, 3120.5f, 3122.3f, 3115.9f, 3138.9f, 3205.9f, 3200.0f, 3239.8f, 3220.7f, 3263.4f, 3213.8f, 3241.7f, 3188.8f, 3139.5f, 3130.8f, 3089.6f, 3104.8f, 3160.8f, 3174.8f, 3176.0f, 3198.2f, 3187.9f, 3219.2f, 3219.4f, 3179.9f, 3220.7f, 3230.7f, 3250.6f, 3283.2f, 3286.8f, 3282.2f, 3274.3f, 3255.1f, 3258.2f, 3208.7f, 3199.8f, 3222.8f, 3298.7f, 3297.1f, 3303.3f, 3293.5f, 3328.9f, 3320.3f, 3316.2f, 3289.5f, 3324.0f, 3305.6f, 3288.9f, 3232.3f, 3274.9f, 3236.4f, 3209.3f, 3246.9f, 3243.7f, 3251.1f, 3216.3f, 3174.9f, 3210.4f, 3227.7f, 3258.2f, 3238.5f, 3216.3f, 3189.7f, 3197.3f, 3215.4f, 3302.2f, 3272.3f, 3308.8f, 3319.9f, 3322.9f, 3329.2f, 3271.9f, 3272.4f, 3259.9f, 3340.6f, 3514.7f, 3514.7f, 3491.7f, 3496.8f, 3470.1f, 3463.3f, 3368.3f, 3394.8f, 3399.2f, 3388.3f, 3396.9f, 3355.4f, 3421.4f, 3452.1f, 3440.7f, 3399.9f, 3443.6f, 3484.1f, 3470.6f, 3462.5f, 3442.1f, 3448.8f, 3449.8f, 3458.4f, 3435.8f, 3367.1f, 3401.7f, 3382.2f, 3398.2f, 3387.8f, 3381.3f, 3375.6f, 3376.2f, 3390.9f, 3356.8f, 3379.2f, 3418.5f, 3429.3f, 3429.9f, 3455.2f, 3441.9f };
private List<float> highPrices = new List<float> { 3388.0f, 3432.0f, 3477.3f, 3453.0f, 3418.8f, 3413.9f, 3437.0f, 3393.0f, 3293.0f, 3238.9f, 3234.0f, 3244.8f, 3118.8f, 3138.8f, 3237.8f, 3250.6f, 3318.0f, 3345.0f, 3362.9f, 3330.0f, 3333.0f, 3310.9f, 3333.0f, 3317.9f, 3272.0f, 3268.5f, 3319.4f, 3305.0f, 3225.0f, 3136.2f, 3110.0f, 3057.0f, 3028.9f, 3076.9f, 3078.9f, 3171.9f, 3184.0f, 3197.0f, 3171.0f, 3186.4f, 3168.9f, 3194.1f, 3264.0f, 3317.3f, 3327.0f, 3312.9f, 3349.0f, 3387.9f, 3377.0f, 3365.1f, 3378.9f, 3385.0f, 3428.7f, 3419.0f, 3414.8f, 3417.9f, 3392.0f, 3421.5f, 3384.1f, 3341.9f, 3308.0f, 3278.2f, 3257.0f, 3142.7f, 3226.5f, 3190.0f, 3163.0f, 3147.9f, 3140.8f, 3161.9f, 3183.5f, 3233.5f, 3269.8f, 3263.4f, 3141.4f, 3137.8f, 3094.3f, 3042.0f, 3079.9f, 3041.4f, 3029.9f, 3022.5f, 3025.8f, 3025.0f, 3049.9f, 3055.8f, 3019.7f, 3004.6f, 3020.7f, 3098.0f, 3124.0f, 3105.0f, 3127.0f, 3145.0f, 3109.9f, 3110.0f, 3150.0f, 3128.4f, 3155.3f, 3159.0f, 3160.0f, 3160.4f, 3178.0f, 3161.7f, 3184.2f, 3174.0f, 3178.5f, 3199.0f, 3262.6f, 3270.0f, 3228.1f, 3220.1f, 3242.8f, 3249.8f, 3225.0f, 3341.6f, 3315.9f, 3349.0f, 3339.9f, 3367.9f, 3360.0f, 3362.8f, 3333.7f, 3318.9f, 3330.0f, 3392.9f, 3403.3f, 3417.0f, 3429.0f, 3414.9f, 3480.0f, 3468.9f, 3439.2f, 3407.9f, 3393.7f, 3380.6f, 3374.1f, 3296.0f, 3336.4f, 3377.0f, 3364.8f, 3292.0f, 3245.5f, 3249.0f, 3283.1f, 3294.0f, 3266.8f, 3272.0f, 3273.8f, 3266.1f, 3271.5f, 3299.0f, 3266.8f, 3320.0f, 3327.3f, 3337.3f, 3301.6f, 3327.0f, 3298.0f, 3349.5f, 3350.0f, 3379.0f, 3353.0f, 3381.8f, 3408.9f, 3387.0f, 3394.7f, 3419.0f, 3451.9f, 3435.0f, 3446.0f, 3458.4f, 3449.0f, 3419.0f, 3469.0f, 3504.0f, 3473.2f, 3493.0f, 3539.9f, 3547.6f, 3542.3f, 3549.0f, 3524.8f, 3526.0f, 3575.0f, 3538.9f, 3522.0f, 3508.9f, 3447.0f, 3452.4f, 3433.9f, 3390.0f, 3392.0f, 3389.0f, 3369.9f, 3358.0f, 3404.9f, 3396.0f, 3385.0f, 3337.2f, 3369.8f, 3304.4f, 3260.3f, 3219.8f, 3221.4f, 3169.7f, 3156.8f, 3143.5f, 3146.3f, 3170.0f, 3152.8f, 3149.6f, 3150.0f, 3213.0f, 3224.9f, 3264.3f, 3257.3f, 3272.0f, 3272.9f, 3260.9f, 3230.0f, 3163.4f, 3156.8f, 3140.0f, 3113.0f, 3164.4f, 3180.9f, 3191.2f, 3208.4f, 3199.2f, 3227.2f, 3235.0f, 3216.0f, 3224.4f, 3244.0f, 3254.8f, 3298.0f, 3306.5f, 3309.7f, 3290.0f, 3292.0f, 3285.0f, 3280.0f, 3228.9f, 3234.5f, 3308.4f, 3327.9f, 3317.2f, 3306.0f, 3338.7f, 3372.0f, 3326.9f, 3327.7f, 3340.0f, 3335.9f, 3327.0f, 3288.8f, 3278.8f, 3270.0f, 3250.0f, 3254.4f, 3265.0f, 3255.8f, 3247.4f, 3199.4f, 3214.9f, 3232.5f, 3261.4f, 3267.7f, 3249.4f, 3213.9f, 3209.7f, 3230.9f, 3310.0f, 3318.8f, 3315.0f, 3329.0f, 3328.4f, 3356.9f, 3324.8f, 3295.0f, 3289.2f, 3367.4f, 3524.8f, 3514.7f, 3549.9f, 3524.0f, 3516.8f, 3478.9f, 3434.9f, 3413.4f, 3406.8f, 3420.8f, 3411.7f, 3393.7f, 3426.7f, 3460.0f, 3446.4f, 3433.2f, 3471.0f, 3488.0f, 3489.9f, 3467.0f, 3464.9f, 3466.7f, 3455.0f, 3466.0f, 3460.8f, 3410.0f, 3409.8f, 3411.0f, 3402.0f, 3413.1f, 3385.8f, 3394.0f, 3389.6f, 3408.1f, 3417.4f, 3389.0f, 3432.8f, 3447.0f, 3443.9f, 3460.0f, 3465.0f };
private List<float> lowPrices = new List<float> { 3340.1f, 3346.3f, 3431.2f, 3377.2f, 3356.0f, 3346.5f, 3353.1f, 3352.0f, 3192.4f, 3174.7f, 3201.0f, 3133.1f, 3023.8f, 3069.0f, 3125.4f, 3183.0f, 3222.9f, 3277.5f, 3306.5f, 3272.6f, 3271.0f, 3255.0f, 3252.1f, 3225.1f, 3206.9f, 3202.2f, 3265.1f, 3250.0f, 3106.0f, 3080.2f, 3035.0f, 2967.0f, 2953.0f, 3014.3f, 3030.1f, 3098.1f, 3144.1f, 3143.5f, 3171.0f, 3149.1f, 3096.5f, 3110.0f, 3201.7f, 3275.0f, 3271.0f, 3271.7f, 3277.1f, 3307.3f, 3355.0f, 3365.1f, 3336.0f, 3335.0f, 3375.1f, 3381.2f, 3387.5f, 3371.1f, 3362.0f, 3371.2f, 3347.4f, 3270.0f, 3250.2f, 3214.8f, 3216.8f, 3081.0f, 3142.1f, 3121.0f, 3120.3f, 3112.2f, 3106.3f, 3102.0f, 3160.1f, 3168.5f, 3225.0f, 3225.0f, 3113.8f, 3100.0f, 3000.0f, 2987.8f, 3030.0f, 2998.2f, 2979.3f, 2979.0f, 2926.1f, 2976.0f, 2980.0f, 2990.0f, 2950.1f, 3004.6f, 2974.0f, 3023.0f, 3092.4f, 3058.1f, 3005.0f, 3053.3f, 3062.1f, 3052.3f, 3071.0f, 3071.4f, 3128.6f, 3112.0f, 3105.0f, 3127.0f, 3155.0f, 3161.7f, 3151.2f, 3134.3f, 3145.0f, 3177.8f, 3203.4f, 3222.1f, 3195.0f, 3166.2f, 3195.1f, 3201.7f, 3170.0f, 3255.1f, 3315.9f, 3309.0f, 3292.0f, 3321.4f, 3317.8f, 3321.0f, 3273.0f, 3255.2f, 3291.0f, 3308.3f, 3348.0f, 3365.6f, 3383.0f, 3375.0f, 3420.0f, 3413.0f, 3407.0f, 3368.0f, 3354.0f, 3339.4f, 3276.3f, 3236.1f, 3267.8f, 3340.9f, 3298.9f, 3225.2f, 3194.5f, 3163.7f, 3240.0f, 3245.1f, 3217.0f, 3225.1f, 3231.5f, 3226.0f, 3228.0f, 3246.2f, 3235.2f, 3245.3f, 3286.2f, 3281.9f, 3200.0f, 3221.2f, 3230.1f, 3271.2f, 3315.6f, 3305.0f, 3298.1f, 3321.0f, 3372.2f, 3361.0f, 3355.6f, 3355.6f, 3417.3f, 3405.0f, 3382.3f, 3385.6f, 3351.0f, 3355.0f, 3420.1f, 3452.9f, 3436.8f, 3461.4f, 3478.1f, 3505.3f, 3508.2f, 3473.4f, 3495.0f, 3460.2f, 3527.0f, 3490.0f, 3475.1f, 3444.8f, 3395.0f, 3408.0f, 3382.3f, 3316.0f, 3299.9f, 3315.0f, 3318.0f, 3331.1f, 3359.0f, 3330.8f, 3330.8f, 3290.0f, 3272.0f, 3209.4f, 3192.0f, 3172.0f, 3144.0f, 3095.1f, 3097.4f, 3106.1f, 3101.0f, 3106.0f, 3106.0f, 3110.2f, 3104.1f, 3152.0f, 3173.8f, 3185.5f, 3215.0f, 3215.0f, 3192.2f, 3199.0f, 3180.0f, 3070.2f, 3110.6f, 3071.5f, 3078.0f, 3100.8f, 3126.2f, 3147.5f, 3181.0f, 3170.7f, 3196.2f, 3210.0f, 3173.2f, 3178.0f, 3210.1f, 3231.3f, 3246.0f, 3266.1f, 3272.0f, 3260.0f, 3248.3f, 3250.4f, 3198.2f, 3195.0f, 3203.1f, 3217.1f, 3290.1f, 3276.0f, 3267.1f, 3291.0f, 3312.0f, 3301.3f, 3265.2f, 3297.5f, 3297.4f, 3285.1f, 3220.6f, 3241.0f, 3233.0f, 3205.3f, 3211.0f, 3239.0f, 3225.8f, 3210.0f, 3156.0f, 3175.0f, 3201.1f, 3223.9f, 3230.1f, 3209.2f, 3173.0f, 3182.3f, 3193.4f, 3214.1f, 3268.8f, 3277.3f, 3305.0f, 3302.0f, 3302.0f, 3265.2f, 3260.8f, 3250.1f, 3272.8f, 3352.0f, 3514.7f, 3477.1f, 3465.0f, 3445.7f, 3436.1f, 3359.1f, 3372.1f, 3380.2f, 3385.0f, 3385.1f, 3331.0f, 3360.9f, 3415.0f, 3413.6f, 3368.0f, 3401.2f, 3441.2f, 3456.6f, 3425.1f, 3430.1f, 3414.0f, 3411.0f, 3435.2f, 3413.2f, 3356.5f, 3372.0f, 3365.1f, 3376.0f, 3378.1f, 3350.2f, 3360.1f, 3365.0f, 3383.1f, 3343.7f, 3356.8f, 3370.1f, 3405.2f, 3398.1f, 3422.3f, 3435.1f  };
    
    public float money=10000.0f;
    public float profit;
    public int shares=0;
    public int sharehas;
    public TextMeshPro Tshares;
    public TextMeshPro moneys;
    private int currentIndex = -1;
    private float previousEnd = 0;
    private float xOffset = 0.5f; // Set this to the desired distance between LineRenderers
int i=0;
    float alpha;
    public float height = 1000f;
     private float interval = 2.0f;
    void Start()
    {
        float maxValue = Mathf.Max(Mathf.Max(openPrices.ToArray()), Mathf.Max(highPrices.ToArray()));
        float minValue = Mathf.Min(Mathf.Min(lowPrices.ToArray()), Mathf.Min(closePrices.ToArray()));
        alpha = height / (maxValue - minValue);
        InvokeRepeating("GenerateGraph", 0.0f, interval);
        Tshares.SetText(""+shares);
        moneys.SetText("Investment:"+money+" |  Profit:"+ profit+"\n shares available:"+sharehas);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateGraph();
        }
    }

    void GenerateGraph()
    {   i++;
        if(i>18)
        {
            gameObject.transform.position=new Vector3(gameObject.transform.position.x+0.4f, gameObject.transform.position.y,gameObject.transform.position.z);
        }
        if (currentIndex < openPrices.Count - 1)
        {
            currentIndex++;
            GameObject lineObject = Instantiate(linePrefab);
            LineRenderer lineRenderer = lineObject.GetComponent<LineRenderer>();

            // Calculate the height of the LineRenderer based on the difference between the opening and closing prices
            float height = (closePrices[currentIndex] - openPrices[currentIndex]);
            lineRenderer.startWidth = lineRenderer.endWidth = lineRenderer.startWidth / 3;
            // Set the position of the LineRenderer
            Vector3 startPoint = new Vector3(currentIndex * xOffset,( previousEnd * 0.5f * alpha), 0);
            Vector3 endPoint = new Vector3(currentIndex * xOffset, ((previousEnd + height) * 0.5f * alpha), 0);
            if (height < 0)
            {
                lineRenderer.SetPosition(0, endPoint);
                lineRenderer.SetPosition(1, startPoint);
                lineObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                // Set the direction of the LineRenderer as normal
                lineRenderer.SetPosition(0, startPoint);
                lineRenderer.SetPosition(1, endPoint);
            }

            // Add high and low lines
            GameObject highLowLineObject = Instantiate(linePrefab);
            LineRenderer highLowLineRenderer = highLowLineObject.GetComponent<LineRenderer>();
            highLowLineRenderer.startWidth = highLowLineRenderer.endWidth = highLowLineRenderer.startWidth / 12;

            // Calculate the positions for the high and low lines
            Vector3 highPoint = new Vector3(currentIndex * xOffset, ((previousEnd + (highPrices[currentIndex] - openPrices[currentIndex])*20.0f/height)) * 0.5f * alpha, 0);
            Vector3 lowPoint = new Vector3(currentIndex * xOffset, (previousEnd + (lowPrices[currentIndex] - openPrices[currentIndex])*20.0f/height) * 0.5f * alpha, 0);

            // Set the positions of the high and low lines
            highLowLineRenderer.SetPosition(0, lowPoint);
            highLowLineRenderer.SetPosition(1, highPoint);
            if (height < 0)
            {
                highLowLineRenderer.GetComponent<Renderer>().material.color = Color.red;
            }
            previousEnd += height;
            money+=shares*height;
            profit += sharehas*height;
            moneys.SetText("Investment:"+money+" |  Profit:"+ profit+"\n shares available:"+sharehas);
        }
    }

    public void upshares()
    {
        shares+=1;
        Tshares.SetText(""+shares);
    }
    public void downshares()
    {   
        if(shares>0)
        shares-=1;
        Tshares.SetText(""+shares);
    }
    public void buy()
    {
      
       
        sharehas=shares+sharehas;
        shares=0;
        Tshares.SetText(""+shares);
    }
    public void sell()
    {
      
        if(sharehas>shares)
        sharehas=shares-sharehas;
        shares=0;
        Tshares.SetText(""+shares);
    }

}
