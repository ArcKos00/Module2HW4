# Module2HW4
  В данном проекте при запуске будет предложено указать количество юнитов с которыми потом будет проводится работа
  Количество врагов(Гоблинов) зависит от количества юнитов (Людей)
До 19 включая юнитов 1 гоблин, 20 и больше по одному на каждые 10 юнитов
  У некоторых юнитов есть свои способности, на каждом ходу будет предоставлен выбор какую способность использовать для каждого юнита у которого больше 1 способности
Всего их 5:
           1)AddPower- навсегда увеличивает урон у 4 союзных юнитов
           2)Charge- наносит юниту противника повышеный физический урон который не блокирует защита
           3)Heal- лечит 4 случайных союзных юнита на 30 (если остался 1 юнит то 4 раза одного и того же) 
           4)FrostBolt- наносит вражескому юниту магический урон который не блокируется, а так же уменьшает скорость передвижения
           5)FireBall- наносит вражескому юниту магический урон который не блокируется, а также уменьшает наносимый целью урон
    Реализован поиск через метод расширения, в поиске можно искать юнитов по расе, типу юнита 
  а так же по характеристикам: имя, урон, броня, скорость а так же по текущему количеству жизней
  После каждого действия табличка с юнитами отрисовывается заново
